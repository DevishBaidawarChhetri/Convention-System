using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConventionSystem
{
    public partial class AddStall : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        List<int> attendeeIds = new List<int>();
        bool AttendeeState = false;
        int StallId = 0;
        public AddStall(int StId)
        {
            InitializeComponent();
            StallId = StId;
        }
        private void StallLoad(int StId)
        {
            if (StId > 0)
            {
                var stall = db.Stalls.Find(StId);
                txt_StallCode.Text = stall.StallCode;
                dp_StallDate.Value = stall.StartingTime;
                txt_Timehm.Text = stall.StartingTime.Hour.ToString() + ":" + stall.StartingTime.Minute.ToString();
                txt_Duration.Text = stall.Duration.ToString();
                cmb_Room.SelectedValue = stall.RoomId;
                txt_StallType.Text = stall.StallType;
                txt_StallSize.Text = stall.Size.ToString();
            }
            dv_Stall.Visible = false;
        }
        private bool CheckStalls(DateTime startDateTime, DateTime endDateTime)
        {
            var stall = db.Stalls.Where(e => e.StartingTime >= startDateTime && e.StartingTime <= endDateTime).FirstOrDefault();
            if (stall != null)
                return true;
            else
                return false;
        }
        private bool CheckInput(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private DateTime getStallStartDateTime()
        {
            if (!CheckInput(txt_Timehm))
            {
                throw new Exception("Expected appropriate format");
            }

            string[] times = txt_Timehm.Text.Split(':');

            int hour = Convert.ToInt32(times[0]);
            if (hour > 12)
            {
                throw new Exception("Use 12 hour clock format");
            }
            if (cmb_TimeFormat.SelectedItem.ToString() == "PM")
            {
                hour += 12;
            }
            DateTime temp = dp_StallDate.Value.Date;
            int min = Convert.ToInt32(times[1]);
            return new DateTime(temp.Year, temp.Month, temp.Day, hour, min, 0);
        }

        private DateTime getStallEndDateTime()
        {
            return getStallStartDateTime().AddHours(Convert.ToInt32(txt_Duration.Text));
        }
        private void AddStall_Load(object sender, EventArgs e)
        {
            cmb_TimeFormat.SelectedIndex = 0;
            cmb_Room.DisplayMember = "Location";
            cmb_Room.ValueMember = "RoomId";
            cmb_Room.DataSource = db.Rooms.ToList();
            StallLoad(StallId);
        }
        private void btnBrowseAttendee_Click(object sender, EventArgs e)
        {
            try
            {
                dv_Stall.Visible = true;
                DateTime startDate = getStallStartDateTime();
                DateTime endDate = getStallEndDateTime();
                var AttendeesBooked = (from a in db.Attendees
                                       join sa in db.AttendeeStalls on a.AttendeeId equals sa.AttendeeId
                                       join s in db.Stalls on sa.StallId equals s.StallId
                                       where (s.StartingTime >= startDate && s.StartingTime <= endDate)
                                       select new { a.AttendeeId, a.Name, a.Email }).ToList();

                var allAttendees = (from a in db.Attendees select new { a.AttendeeId, a.Name, a.Email }).ToList();
                var availableAttendee = allAttendees.Except(AttendeesBooked).ToList();
                btn_SaveAttendee.Text = "Save Exhibitor";
                if (StallId > 0)
                {
                    var selectedAttendee = db.AttendeeStalls.Where(sa => sa.StallId == StallId).Select(a => a.Exhibitor).ToList();
                    var tempAttendee = (from attendee in selectedAttendee select new { attendee.AttendeeId, attendee.Name, attendee.Email }).ToList();
                    dv_Stall.Controls.Clear();
                    foreach (var temp in tempAttendee)
                    {
                        var t = availableAttendee.Where(a => a.AttendeeId == temp.AttendeeId).FirstOrDefault();
                        if (t == null)
                            availableAttendee.Add(temp);
                    }
                    dv_Stall.DataSource = availableAttendee;

                    foreach (DataGridViewRow drv in dv_Stall.Rows)
                    {
                        int attendeeId = Convert.ToInt32(drv.Cells["AttendeeId"].Value);
                        var cboSelect = drv.Cells["cboSelect"];
                        var attendee = tempAttendee.Where(a => a.AttendeeId == attendeeId).FirstOrDefault();
                        if (attendee != null)
                            cboSelect.Value = true;
                    }
                }
                else
                {
                    dv_Stall.DataSource = availableAttendee;
                }
                AttendeeState = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveAttendee_Click(object sender, EventArgs e)
        {
            bool state = false;

            foreach (DataGridViewRow drv in dv_Stall.Rows)
            {
                var check = Convert.ToBoolean(drv.Cells["cboSelect"].Value);

                if (check)
                {
                    state = true;
                    if (AttendeeState)
                        attendeeIds.Add(Convert.ToInt32(drv.Cells["AttendeeId"].Value));

                }

            }
            if (state)
                MessageBox.Show("Attendees successfully added into stall");
            else
                MessageBox.Show("Exhibitor is not selected");
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput(txt_StallCode))
                {
                    throw new Exception("Please enter Title");
                }
                if (!CheckInput(txt_Duration))
                {
                    throw new Exception("Please enter Duration");
                }
                if (!CheckInput(txt_StallSize))
                {
                    throw new Exception("Please enter Description");
                }
                if (!CheckInput(txt_StallType))
                {
                    throw new Exception("Please enter Description");
                }
                Stall stalls;
                List<AttendeePerStall> attendeestalls = new List<AttendeePerStall>();
                if (StallId > 0)
                {
                    stalls = db.Stalls.Find(StallId);
                    attendeestalls = stalls.AttendeeStalls;
                }
                else
                {
                    stalls = new Stall();
                    if (CheckStalls(getStallStartDateTime(), getStallEndDateTime()))
                        throw new Exception("Time is already booked for another stall");
                }
                stalls.StallCode = txt_StallCode.Text;
                stalls.StallType = txt_StallType.Text;
                stalls.Size = Convert.ToInt32(txt_StallSize.Text);
                stalls.StartingTime = getStallStartDateTime();
                stalls.RoomId = Convert.ToInt32(cmb_Room.SelectedValue);
                stalls.Duration = Convert.ToInt32(txt_Duration.Text);

                foreach (int id in attendeeIds)
                {
                    AttendeePerStall attendeeStall = new AttendeePerStall();
                    attendeeStall.Exhibitor = db.Attendees.Find(id);
                    attendeeStall.Stall = stalls;
                    var attendeeCheck = attendeestalls.Where(sa => sa.AttendeeId == id).FirstOrDefault();

                    if (attendeeCheck == null)
                        attendeestalls.Add(attendeeStall);

                }
                if (attendeestalls.Count < 1)
                {
                    throw new Exception("Please add Exhibitor");
                }

                stalls.AttendeeStalls = attendeestalls;
                if (Convert.ToInt32(txt_StallSize.Text) > db.Rooms.Find(cmb_Room.SelectedValue).Capacity)
                {
                    throw new Exception("Stall size cannot be greater than room capacity");
                }
                if (stalls.AttendeeStalls.Count > db.Rooms.Find(cmb_Room.SelectedValue).Capacity)
                {
                    throw new Exception("Max room capacity");
                }
                if (StallId > 0)
                {
                    db.Stalls.Attach(stalls);
                }
                else
                    db.Stalls.Add(stalls);
                db.SaveChanges();
                MessageBox.Show("Stall successfully added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

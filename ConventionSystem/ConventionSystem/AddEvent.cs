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
    public partial class AddEvent : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        List<int> attendeeIds = new List<int>();
        bool AttendeeState = false;
        int EventId = 0;
        public AddEvent(int EvId)
        {
            InitializeComponent();
            EventId = EvId;
        }
        private void EventLoad(int EvId)
        {
            if (EvId > 0)
            {
                var Event = db.Events.Find(EvId);
                txt_Title.Text = Event.EventTitle;
                dp_EventDate.Value = Event.EventDate;
                txt_Timehr.Text = Event.EventDate.Hour.ToString() + ":" + Event.EventDate.Minute.ToString();
                txt_Duration.Text = Event.Duration.ToString();
                cmb_Room.SelectedValue = Event.RoomId;
            }
            dg_Event.Visible = false;
        }
        private bool CheckEvents(DateTime startDateTime, DateTime endDateTime)
        {
            var events = db.Events.Where(e => e.EventDate >= startDateTime && e.EventDate <= endDateTime).FirstOrDefault();
            if (events != null)
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
        private DateTime getEventStartDateTime()
        {
            if (!CheckInput(txt_Timehr))
            {
                throw new Exception("Expected appropriate format");
            }

            string[] times = txt_Timehr.Text.Split(':');

            int hour = Convert.ToInt32(times[0]);
            if (hour > 12)
            {
                throw new Exception("Use 12 hour clock format");
            }
            if (cmb_TimeFormat.SelectedItem.ToString() == "PM")
            {
                hour += 12;
            }
            DateTime temp = dp_EventDate.Value.Date;
            int min = Convert.ToInt32(times[1]);
            return new DateTime(temp.Year, temp.Month, temp.Day, hour, min, 0);
        }

        private DateTime getEventEndDateTime()
        {
            return getEventStartDateTime().AddHours(Convert.ToInt32(txt_Duration.Text));
        }
        private void AddEvent_Load(object sender, EventArgs e)
        {
            cmb_TimeFormat.SelectedIndex = 0;
            cmb_Room.DisplayMember = "Location";
            cmb_Room.ValueMember = "RoomId";
            cmb_Room.DataSource = db.Rooms.ToList();
            EventLoad(EventId);
        }
        private void btnBrowseAttendee_Click(object sender, EventArgs e)
        {
            try
            {
                dg_Event.Visible = true;
                DateTime startDate = getEventStartDateTime();
                DateTime endDate = getEventEndDateTime();
                var AttendeesBooked = (from a in db.Attendees
                                       join ae in db.AttendeeEvents on a.AttendeeId equals ae.AttendeeId
                                       join et in db.Events on ae.EventId equals et.EventId
                                       where (et.EventDate >= startDate && et.EventDate <= endDate)
                                       select new { a.AttendeeId, a.Name, a.Email }).ToList();

                var allAttendees = (from a in db.Attendees select new { a.AttendeeId, a.Name, a.Email }).ToList();
                var availableAttendee = allAttendees.Except(AttendeesBooked).ToList();
                btn_SaveAttendee.Text = "Save Attendee";
                if (EventId > 0)
                {
                    var selectedAttendee = db.AttendeeEvents.Where(ae => ae.EventId == EventId).Select(a => a.Attendee).ToList();
                    var tempAttendee = (from attendee in selectedAttendee select new { attendee.AttendeeId, attendee.Name, attendee.Email }).ToList();
                    dg_Event.Controls.Clear();
                    foreach (var temp in tempAttendee)
                    {
                        var t = availableAttendee.Where(a => a.AttendeeId == temp.AttendeeId).FirstOrDefault();
                        if (t == null)
                            availableAttendee.Add(temp);
                    }
                    dg_Event.DataSource = availableAttendee;

                    foreach (DataGridViewRow drv in dg_Event.Rows)
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
                    dg_Event.DataSource = availableAttendee;
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

            foreach (DataGridViewRow drv in dg_Event.Rows)
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
                MessageBox.Show("Attendees successfully added into event");
            else
                MessageBox.Show("There is no Attendee selected");
        }
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput(txt_Title))
                {
                    throw new Exception("Please enter Title");
                }
                if (!CheckInput(txt_Duration))
                {
                    throw new Exception("Please enter Duration");
                }
                if (!CheckInput(txt_Description))
                {
                    throw new Exception("Please enter Description");
                }
                
                Event events;
                List<AttendeePerEvent> attendeeEvents = new List<AttendeePerEvent>();
                if (EventId > 0)
                {
                    events = db.Events.Find(EventId);
                    attendeeEvents = events.AttendeeEvents;
                }
                else
                {
                    events = new Event();
                    if (CheckEvents(getEventStartDateTime(), getEventEndDateTime()))
                        throw new Exception("Time is already booked for another event");
                }
                events.EventTitle = txt_Title.Text;
                events.EventDate = getEventStartDateTime();
                events.RoomId = Convert.ToInt32(cmb_Room.SelectedValue);
                events.Duration = Convert.ToInt32(txt_Duration.Text);


                foreach (int id in attendeeIds)
                {
                    AttendeePerEvent attendeeEvent = new AttendeePerEvent();
                    attendeeEvent.Attendee = db.Attendees.Find(id);
                    attendeeEvent.Event = events;
                    var attendeeCheck = attendeeEvents.Where(ae => ae.AttendeeId == id).FirstOrDefault();

                    if (attendeeCheck == null)
                        attendeeEvents.Add(attendeeEvent);

                }
                if (attendeeEvents.Count < 1)
                {
                    throw new Exception("Please add Attendee");
                }
                
                events.AttendeeEvents = attendeeEvents;
                if (events.AttendeeEvents.Count > db.Rooms.Find(cmb_Room.SelectedValue).Capacity)
                {
                    throw new Exception("Max room capacity");
                }
                if (EventId > 0)
                {
                    db.Events.Attach(events);
                }
                else
                    db.Events.Add(events);
                db.SaveChanges();
                MessageBox.Show("Event successfully added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        
    }
}

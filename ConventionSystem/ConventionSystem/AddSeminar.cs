using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Data.Entity;

namespace ConventionSystem
{
    public partial class AddSeminar : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        List<int> attendeeIds = new List<int>();
        List<int> presenterIds = new List<int>();
        bool AudienceState = false;
        bool PresenterState = false;
        int seminarId = 0;
        public AddSeminar(int SemId)
        {
            InitializeComponent();
            seminarId = SemId;

        }
        private void SeminarLoad(int SemId)
        {
            if (SemId > 0)
            {
                var seminar = db.Seminars.Find(SemId);
                txt_Title.Text = seminar.SeminarTitle;
                dp_SeminarDate.Value = seminar.SeminarStartTime;
                txt_Timehr.Text = seminar.SeminarStartTime.Hour.ToString() + ":" + seminar.SeminarStartTime.Minute.ToString();
                txt_Duration.Text = seminar.Duration.ToString();
                cmb_Room.SelectedValue = seminar.RoomId;
            }
            dg_Seminar.Visible = false;
        }
        
        private bool CheckSeminar(DateTime startDateTime, DateTime endDateTime)
        {
            var seminar = db.Seminars.Where(s => s.SeminarStartTime >= startDateTime && s.SeminarStartTime <= endDateTime).FirstOrDefault();
            if (seminar != null)
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
        private void AddSeminar_Load(object sender, EventArgs e)
        {
            cmb_TimeFormat.SelectedIndex = 0;
            cmb_Room.DisplayMember = "Location";
            cmb_Room.ValueMember = "RoomId";
            cmb_Room.DataSource = db.Rooms.ToList();
            SeminarLoad(seminarId);
        }
        private DateTime getSeminarStartDateTime()
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
            DateTime temp = dp_SeminarDate.Value.Date;
            int min = Convert.ToInt32(times[1]);
            return new DateTime(temp.Year, temp.Month, temp.Day, hour, min, 0);
        }
        private DateTime getSeminarEndDateTime()
        {
            return getSeminarStartDateTime().AddHours(Convert.ToInt32(txt_Duration.Text));
        }


        private void btnBrowseAudience_Click(object sender, EventArgs e)
        {
            try
            {
                dg_Seminar.Visible = true;
                DateTime startDate = getSeminarStartDateTime();
                DateTime endDate = getSeminarEndDateTime();
                var AttendeesBooked = (from a in db.Attendees
                                       join au in db.AudienceSeminars on a.AttendeeId equals au.AttendeeId
                                       join s in db.Seminars on au.SeminarId equals s.SeminarId
                                       where (s.SeminarStartTime >= startDate && s.SeminarStartTime <= endDate)
                                       select new { a.AttendeeId, a.Name, a.Email }).ToList();

                var allAttendees = (from a in db.Attendees select new { a.AttendeeId, a.Name, a.Email }).ToList();
                var availableAudience = allAttendees.Except(AttendeesBooked).ToList();
                btn_SaveAudiencePresenter.Text = "Save Audience";
                if (seminarId > 0)
                {
                    var selectedAudience = db.AudienceSeminars.Where(au => au.SeminarId == seminarId).Select(a => a.Attendee).ToList();
                    var tempAudience = (from attendee in selectedAudience select new { attendee.AttendeeId, attendee.Name, attendee.Email }).ToList();
                    dg_Seminar.Controls.Clear();
                    foreach (var temp in tempAudience)
                    {
                        var t = availableAudience.Where(a => a.AttendeeId == temp.AttendeeId).FirstOrDefault();
                        if (t == null)
                            availableAudience.Add(temp);
                    }
                    dg_Seminar.DataSource = availableAudience;

                    foreach (DataGridViewRow drv in dg_Seminar.Rows)
                    {
                        int attendeeId = Convert.ToInt32(drv.Cells["AttendeeId"].Value);
                        var cboSelect = drv.Cells["cboSelect"];
                        var attendee = tempAudience.Where(a => a.AttendeeId == attendeeId).FirstOrDefault();
                        if (attendee != null)
                            cboSelect.Value = true;
                    }
                }
                else
                {
                    dg_Seminar.DataSource = availableAudience;
                }
                AudienceState = true;
                PresenterState = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowsePresenter_Click(object sender, EventArgs e)
        {
            try
            {
                dg_Seminar.Visible = true;
                dg_Seminar.Controls.Clear();
                DateTime startDate = getSeminarStartDateTime();
                DateTime endDate = getSeminarEndDateTime();
                var bookedPresenters = (from a in db.Attendees
                                        join pa in db.PresenterSeminars on a.AttendeeId equals pa.AttendeeId
                                        join s in db.Seminars on pa.SeminarId equals s.SeminarId
                                        where (s.SeminarStartTime >= startDate && s.SeminarStartTime <= endDate)
                                        select new { a.AttendeeId, a.Name, a.Email }).ToList();

                var allPresenters = (from a in db.Attendees select new { a.AttendeeId, a.Name, a.Email }).ToList();
                var freePresenters = allPresenters.Except(bookedPresenters).ToList();
                dg_Seminar.DataSource = freePresenters;
                btn_SaveAudiencePresenter.Text = "Save Presenter";

                if (seminarId > 0)
                {
                    var selectedPresenters = db.PresenterSeminars.Where(pa => pa.SeminarId == seminarId).Select(a => a.Presenter).ToList();
                    var tempPresenters = (from attendee in selectedPresenters select new { attendee.AttendeeId, attendee.Name, attendee.Email }).ToList();

                    dg_Seminar.Controls.Clear();

                    foreach (var temp in tempPresenters)
                    {
                        var t = allPresenters.Where(a => a.AttendeeId == temp.AttendeeId).FirstOrDefault();
                        if (t == null)
                            allPresenters.Add(temp);
                    }
                    dg_Seminar.DataSource = allPresenters;

                    foreach (DataGridViewRow drv in dg_Seminar.Rows)
                    {
                        int attendeeId = Convert.ToInt32(drv.Cells["AttendeeId"].Value);
                        var cboSelect = drv.Cells["cboSelect"];
                        var attendee = tempPresenters.Where(a => a.AttendeeId == attendeeId).FirstOrDefault();
                        if (attendee != null)
                            cboSelect.Value = true;
                    }
                }
                else
                {
                    dg_Seminar.DataSource = allPresenters;
                }

                PresenterState = true;
                AudienceState = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveAudiencePresenter_Click(object sender, EventArgs e)
        {
            bool state = false;

            foreach (DataGridViewRow drv in dg_Seminar.Rows)
            {
                var check = Convert.ToBoolean(drv.Cells["cboSelect"].Value);

                if (check)
                {
                    state = true;
                    if (AudienceState)
                        attendeeIds.Add(Convert.ToInt32(drv.Cells["AttendeeId"].Value));
                    if (PresenterState)
                        presenterIds.Add(Convert.ToInt32(drv.Cells["AttendeeId"].Value));
                }

            }
            if (state)
                MessageBox.Show("Attendees successfully added into seminar");
            else
                MessageBox.Show("There is no Audience selected");
        }

        private void btnAddSeminar_Click(object sender, EventArgs e)
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
                Seminar seminar;
                List<AudiencePerSeminar> audienceSeminars = new List<AudiencePerSeminar>();
                List<PresenterPerSeminar> presenterSeminars = new List<PresenterPerSeminar>();
                if (seminarId > 0)
                {
                    seminar = db.Seminars.Find(seminarId);
                    audienceSeminars = seminar.AudienceSeminars;
                    presenterSeminars = seminar.PresenterSeminars;
                }
                else
                {
                    seminar = new Seminar();
                    if (CheckSeminar(getSeminarStartDateTime(), getSeminarEndDateTime()))
                        throw new Exception("Time is already booked for another seminar");
                }
                seminar.SeminarTitle = txt_Title.Text;
                seminar.SeminarStartTime = getSeminarStartDateTime();
                seminar.RoomId = Convert.ToInt32(cmb_Room.SelectedValue);
                seminar.Duration = Convert.ToInt32(txt_Duration.Text);


                foreach (int id in attendeeIds)
                {
                    AudiencePerSeminar audienceSeminar = new AudiencePerSeminar();
                    audienceSeminar.Attendee = db.Attendees.Find(id);
                    audienceSeminar.Seminar = seminar;
                    var attendeeCheck = audienceSeminars.Where(au => au.AttendeeId == id).FirstOrDefault();

                    if (attendeeCheck == null)
                        audienceSeminars.Add(audienceSeminar);

                }

                foreach (int id in presenterIds)
                {
                    PresenterPerSeminar presenterSeminar = new PresenterPerSeminar();
                    presenterSeminar.Presenter = db.Attendees.Find(id);
                    presenterSeminar.Seminar = seminar;
                    var presenter = presenterSeminars.Where(pa => pa.AttendeeId == id).FirstOrDefault();
                    if (presenter == null)
                        presenterSeminars.Add(presenterSeminar);
                }
                if (audienceSeminars.Count < 1)
                {
                    throw new Exception("Please add Audience");
                }
                if (presenterSeminars.Count < 1)
                {
                    throw new Exception("Please add Presenter");
                }
                    seminar.AudienceSeminars = audienceSeminars;
                if (seminar.AudienceSeminars.Count > db.Rooms.Find(cmb_Room.SelectedValue).Capacity)
                {
                    throw new Exception("Max room capacity");
                }
                seminar.PresenterSeminars = presenterSeminars;

                if (seminarId > 0)
                {
                    db.Seminars.Attach(seminar);
                }
                else
                    db.Seminars.Add(seminar);
                db.SaveChanges();
                MessageBox.Show("Seminar successfully added");
            }
         catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
    }
}
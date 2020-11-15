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
    public partial class AttendeeSchedule : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        int LoggedId;
        public AttendeeSchedule(int UserId)
        {
            InitializeComponent();
            LoggedId = UserId;
        }

        private void AttendeeSchedule_Load(object sender, EventArgs e)
        {
            var myAudienceSeminars = (from a in db.Attendees
                              join au in db.AudienceSeminars on a.AttendeeId equals au.AttendeeId
                              join s in db.Seminars on au.SeminarId equals s.SeminarId
                              where au.AttendeeId == LoggedId
                              select new { Type = "Seminar", s.SeminarTitle, s.SeminarStartTime, s.Duration, s.Room.Location, s.Room.Resources }).ToList();
            var myPresenterSeminars = (from a in db.Attendees
                              join pa in db.PresenterSeminars on a.AttendeeId equals pa.AttendeeId
                              join s in db.Seminars on pa.SeminarId equals s.SeminarId
                              where pa.AttendeeId == LoggedId
                              select new { Type = "Seminar", s.SeminarTitle, s.SeminarStartTime, s.Duration, s.Room.Location, s.Room.Resources }).ToList();
            var myEvents= (from a in db.Attendees
                           join ae in db.AttendeeEvents on a.AttendeeId equals ae.EventId
                           join et in db.Events on ae.EventId equals et.EventId
                           where ae.AttendeeId == LoggedId
                           select new { Type = "Event", et.EventTitle, et.EventDate, et.Duration,et.EventDesc, et.Room.Resources, et.Room.Location }).ToList();
            var myStalls = (from a in db.Attendees
                            join sa in db.AttendeeStalls on a.AttendeeId equals sa.StallId
                            join s in db.Stalls on sa.StallId equals s.StallId
                            where sa.AttendeeId == LoggedId
                            select new { Type = "Stall", s.StallCode, s.StartingTime, s.Duration, s.StallType, s.Size, s.Room.Location, s.Room.Resources }).ToList();
            dg_AudienceSeminar.DataSource = myAudienceSeminars;
            dg_PresenterSeminar.DataSource = myPresenterSeminars;
            dg_AttendeeStall.DataSource = myStalls;
            dg_AttendeeEvent.DataSource = myEvents;
            
            
        }

        
    }
}

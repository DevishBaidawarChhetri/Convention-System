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
    public partial class EventSchedule : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public EventSchedule()
        {
            InitializeComponent();
        }

        private void EventSchedule_Load(object sender, EventArgs e)
        {
            var events = (from et in db.Events select new { et.EventTitle, et.EventDesc, et.EventDate, et.Duration, NumbersOfAttendees = et.AttendeeEvents.Count, et.Room.Location, et.Room.Capacity, et.Room.Resources }).ToList();
            dg_ScheduleEvent.DataSource = events;
        }
    }
}

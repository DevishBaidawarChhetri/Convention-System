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
    public partial class StallSchedule : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public StallSchedule()
        {
            InitializeComponent();
        }

        private void StallSchedule_Load(object sender, EventArgs e)
        {
            var stalls = (from s in db.Stalls select new { s.StallCode, s.StartingTime, s.Duration, s.Size,s.StallType, NumbersOfAttendees = s.AttendeeStalls, s.Room.Location, s.Room.Capacity, s.Room.Resources }).ToList();
            dg_ScheduleStall.DataSource = stalls;
        }
    }
}

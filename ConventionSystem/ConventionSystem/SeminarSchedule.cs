using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ConventionSystem
{
    public partial class SeminarSchedule : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public SeminarSchedule()
        {
            InitializeComponent();
        }

        private void SeminarSchedule_Load(object sender, EventArgs e)
        {
            var seminars = (from s in db.Seminars select new { s.SeminarTitle, s.SeminarStartTime, s.Duration, NumbersOfAttendees = s.AudienceSeminars.Count+s.PresenterSeminars.Count, s.Room.Location, s.Room.Capacity, s.Room.Resources }).ToList();
            dg_ScheduleSeminar.DataSource = seminars;

        }

        
    }
}

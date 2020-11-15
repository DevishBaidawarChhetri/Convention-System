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
    public partial class RoomSchedule : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public RoomSchedule()
        {
            InitializeComponent();
        }

        private void RoomSchedule_Load(object sender, EventArgs e)
        {
            var rooms = (from r in db.Rooms select new { r.Location, r.Capacity, r.Resources}).ToList();
            dg_ScheduleRoom.DataSource = rooms;
        }
    }
}

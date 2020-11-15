using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConventionSystem
{
    public partial class AttendeeHome : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public int Loggeduser { get; set; }
        public AttendeeHome()
        {
            InitializeComponent();
        }

        private void btnAttendeeSchedule_Click(object sender, EventArgs e)
        {
            AttendeeSchedule Schedule = new AttendeeSchedule(Loggeduser);
            Schedule.Show();
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            Loggeduser = 0;
            this.Close();
            Login User = new Login();
            User.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditAttendee edit = new EditAttendee(Loggeduser);
            edit.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure to delete account", "Delete Account?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var attendee = db.Attendees.Where(a => a.AttendeeId == Loggeduser).Include(a => a.PresenterSeminars).Include(a => a.AudienceSeminars).Include(a => a.AttendeeEvents).Include(a => a.AttendeeStalls).FirstOrDefault();
                db.Attendees.Remove(attendee);
                db.SaveChanges();
                Loggeduser = 0;
                Login User = new Login();
                MessageBox.Show("Account deleted successfully");
                User.Show();
                this.Close();
            }
            
        }
    }
}

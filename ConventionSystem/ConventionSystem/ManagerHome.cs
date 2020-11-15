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
    public partial class ManagerHome : Form
    {
        
        public ManagerHome()
        {
            InitializeComponent();
        }

        private void addAttendeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAttendee add = new AddAttendee();
            add.Show();
        }

        private void addSeminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSeminar seminar = new AddSeminar(0);
            seminar.Show();
        }

        private void displayAttendeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAttendee attendeelist = new ShowAttendee();
            attendeelist.Show();
        }

        private void displaySeminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSeminar seminarlist = new ShowSeminar();
            seminarlist.Show();
        }

        private void viewSeminarScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeminarSchedule schedule = new SeminarSchedule();
            schedule.Show();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEvent add = new AddEvent(0);
            add.Show();

        }

        private void displayEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowEvent eventlist = new ShowEvent();
            eventlist.Show();
        }

        private void viewEventScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventSchedule schedule = new EventSchedule();
            schedule.Show();
        }

        private void addStallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStall add = new AddStall(0);
            add.Show();
        }

        private void displayStallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStall stalllist = new ShowStall();
            stalllist.Show();
        }

        private void viewStallScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StallSchedule schedule = new StallSchedule();
            schedule.Show();
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRoom add = new AddRoom();
            add.Show();
        }

        private void displayRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoom roomlist = new ShowRoom();
            roomlist.Show();
        }

        private void viewRoomScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomSchedule schedule = new RoomSchedule();
            schedule.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login user = new Login();
            user.Show();
        }

        private void btnEditprofile_Click(object sender, EventArgs e)
        {
            EditManager edit = new EditManager();
            edit.Show();
        }

       
    }
}

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
    public partial class ShowAttendee : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public ShowAttendee()
        {
            InitializeComponent();
        }

        private void ViewAttendee_Load(object sender, EventArgs e)
        {
            LoadAttendee();
        }

        private void dg_AttendeeSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dg_AttendeeSchedule.Rows[e.RowIndex].Cells["AttendeeId"].Value);
            if (dg_AttendeeSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string command = dg_AttendeeSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (command.ToLower() == "delete")
                {
                    try
                    {
                        if (MessageBox.Show("Do you want to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var attendees = db.Attendees.Where(rm => rm.AttendeeId == id).FirstOrDefault();
                            db.Attendees.Remove(attendees);
                            db.SaveChanges();
                            MessageBox.Show("Attendee Successfully deleted");
                            LoadAttendee();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void LoadAttendee()
        {
            var attendees = (from a in db.Attendees select new { a.Name, a.Email, a.TypeTicket, a.AttendDays,a.AttendeeId }).ToList();
            dg_AttendeeSchedule.DataSource = attendees;
        }
    }
}

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
    public partial class EditAttendee : Form
    {
        int Loggeduser;
        ConventionSystemContext db = new ConventionSystemContext();
        public EditAttendee(int UserId)
        {
            Loggeduser = UserId;
            InitializeComponent();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            ChangePassword password = new ChangePassword(Loggeduser);
            password.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput(txt_Name))
                {
                    throw new Exception("Please enter Name");
                }
                if (!CheckInput(txt_Email))
                {
                    throw new Exception("Please enter Email");
                }
                if (!CheckInput(txt_AttendDays))
                {
                    throw new Exception("Please enter Attend days");
                }
                var check = db.Attendees.Single(up => up.Password == txt_ConfirmPassword.Text);
                if (check != null)
                {
                    var update = (from a in db.Attendees where a.AttendeeId == Loggeduser select a).First();
                    update.Email = txt_Email.Text;
                    update.Name = txt_Name.Text;
                    update.TypeTicket = cmb_Ticket.Text.ToString();
                    update.AttendDays = Convert.ToInt32(txt_AttendDays.Text);
                    db.SaveChanges();
                    MessageBox.Show("Updated successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void EditAttendee_Load(object sender, EventArgs e)
        {
            var attendee = db.Attendees.Find(Loggeduser);
            txt_Name.Text = attendee.Name;
            txt_Email.Text = attendee.Email;
            cmb_Ticket.Text = attendee.TypeTicket;
            txt_AttendDays.Text = attendee.AttendDays.ToString();

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
    }
}

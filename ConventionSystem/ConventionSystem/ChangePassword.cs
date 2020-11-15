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
    public partial class ChangePassword : Form
    {
        int Loggeduser;
        ConventionSystemContext db = new ConventionSystemContext();
        public ChangePassword(int UserId)
        {
            Loggeduser = UserId;
            InitializeComponent();
        }

        private void ChangePasswordAttendee_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput(txt_OldPassword))
                {
                    throw new Exception("Please enter Old password");
                }
                if (!CheckInput(txt_NewPassword))
                {
                    throw new Exception("Please enter New password");
                }
                var check = db.Attendees.Single(up => up.Password == txt_OldPassword.Text);
            if (check != null)
            {
                    
                    if (txt_RenewPassword.Text == txt_NewPassword.Text)
                {
                    var update = (from a in db.Attendees where a.AttendeeId == Loggeduser select a).First();
                    update.Password = txt_NewPassword.Text;
                    db.SaveChanges();
                    MessageBox.Show("Updated successfully");
                }
                else
                    MessageBox.Show("Incorrect Re-Password");
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

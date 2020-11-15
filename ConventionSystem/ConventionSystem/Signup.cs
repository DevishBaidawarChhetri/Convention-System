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
    public partial class Signup : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();

        public Signup()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login user = new Login();
            user.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput(txt_Email))
                {
                    throw new Exception("Please enter Email");
                }
                if (!CheckInput(txt_Name))
                {
                    throw new Exception("Please enter name");
                }
                if (!CheckInput(txt_Password))
                {
                    throw new Exception("Please enter password");
                }
                if (!CheckInput(txt_AttendDays))
                {
                    throw new Exception("Please enter attend days");
                }
                if (txt_Password.Text == txt_Repassword.Text)
                {
                    Attendee attendee = new Attendee();
                    attendee.Name = txt_Name.Text;
                    attendee.Email = txt_Email.Text;
                    attendee.Password = txt_Password.Text;
                    attendee.TypeTicket = cmb_TicketType.Text.ToString();
                    attendee.AttendDays = Convert.ToInt32(txt_AttendDays.Text);
                    db.Attendees.Add(attendee);
                    db.SaveChanges();
                    MessageBox.Show("Account created successfully");
                }
                else MessageBox.Show("Incorrect Repassword");
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

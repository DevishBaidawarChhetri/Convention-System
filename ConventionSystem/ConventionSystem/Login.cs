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
    public partial class Login : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput(txt_Email))
                {
                    throw new Exception("Please enter Email");
                }
                if (!CheckInput(txt_Password))
                {
                    throw new Exception("Please enter password");
                }
                var user = db.Attendees.Single(u => u.Email == txt_Email.Text && u.Password == txt_Password.Text);
                string type = (from Attendee in db.Attendees where Attendee.Email == txt_Email.Text select Attendee.TypeTicket).First();
                type = type.Replace(" ", string.Empty);
                if (user != null && type == "manager")
                {

                    ManagerHome home = new ManagerHome();
                    home.Show();
                    this.Hide();
                }
                else if (user != null)
                {
                    AttendeeHome home = new AttendeeHome();
                    home.Show();
                    int userid = (from Attendee in db.Attendees where Attendee.Email == txt_Email.Text select Attendee.AttendeeId).FirstOrDefault();
                    home.Loggeduser = userid;
                    this.Hide();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
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

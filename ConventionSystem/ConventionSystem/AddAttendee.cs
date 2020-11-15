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
    public partial class AddAttendee : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public AddAttendee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput(txt_Email))
                {
                    throw new Exception("Please enter Email");
                }
                if (!CheckInput(txt_Name))
                {
                    throw new Exception("Please enter Name");
                }
                if (!CheckInput(txt_AttendDays))
                {
                    throw new Exception("Please enter Attend days");
                }
                Attendee attendee = new Attendee();
                attendee.Name = txt_Name.Text;
                attendee.Email = txt_Email.Text;
                attendee.TypeTicket = cmb_TicketType.Text.ToString();
                attendee.Password = "Password";
                attendee.AttendDays = Convert.ToInt32(txt_AttendDays.Text);
                db.Attendees.Add(attendee);
                db.SaveChanges();
                MessageBox.Show("added successfully");
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

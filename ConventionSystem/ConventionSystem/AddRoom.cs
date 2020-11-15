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
    public partial class AddRoom : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public AddRoom()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput(txt_Location))
                {
                    throw new Exception("Please enter Location");
                }
                if (!CheckInput(txt_Capacity))
                {
                    throw new Exception("Please enter Capacity");
                }
                if (!CheckInput(txt_Resources))
                {
                    throw new Exception("Please enter Resources");
                }
                Room room = new Room();
                room.Location = txt_Location.Text;
                room.Resources = txt_Resources.Text;
                room.Capacity = Convert.ToInt32(txt_Capacity.Text);
                db.Rooms.Add(room);
                db.SaveChanges();
                MessageBox.Show("Room added successfully");
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

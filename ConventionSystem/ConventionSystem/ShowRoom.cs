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
    public partial class ShowRoom : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public ShowRoom()
        {
            InitializeComponent();
        }

        private void dg_Room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dg_Room.Rows[e.RowIndex].Cells["RoomId"].Value);
            if (dg_Room.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string command = dg_Room.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (command.ToLower() == "delete")
                {
                    try
                    {
                        if (MessageBox.Show("Do you want to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var Room = db.Rooms.Where(r => r.RoomId == id).FirstOrDefault();
                            db.Rooms.Remove(Room);
                            db.SaveChanges();
                            MessageBox.Show("Room Successfully deleted");
                            LoadRoom();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                else if (command.ToLower() == "edit")
                {
                    AddRoom addRoom = new AddRoom();
                    addRoom.Show();
                }
            }
        }

        private void ShowRoom_Load(object sender, EventArgs e)
        {
            LoadRoom();
        }
        private void LoadRoom()
        {
            var rooms = (from r in db.Rooms select new { r.Location, r.Capacity, r.Resources, r.RoomId }).ToList();
            dg_Room.DataSource = rooms;
        }
    }
}

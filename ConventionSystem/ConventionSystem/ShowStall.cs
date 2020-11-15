using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace ConventionSystem
{
    public partial class ShowStall : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public ShowStall()
        {
            InitializeComponent();
        }

        private void dgvStall_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dg_Stall.Rows[e.RowIndex].Cells["StallId"].Value);
            if (dg_Stall.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string command = dg_Stall.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (command.ToLower() == "delete")
                {
                    try
                    {
                        if (MessageBox.Show("Do you want to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var stall = db.Stalls.Where(s => s.StallId == id).Include(s => s.AttendeeStalls).Include(s => s.Room).FirstOrDefault();
                            db.Stalls.Remove(stall);
                            db.SaveChanges();
                            MessageBox.Show("Stall Successfully deleted");
                            LoadStall();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                else if (command.ToLower() == "edit")
                {
                    AddStall addStall = new AddStall(id);
                    addStall.Show();
                }
            }
        }

        private void ViewStall_Load(object sender, EventArgs e)
        {
            LoadStall();
        }
        private void LoadStall()
        {
            var stalls = (from s in db.Stalls select new { s.Room.Location, s.StartingTime, s.Duration, s.StallId, s.StallCode, s.Size }).ToList();
            dg_Stall.DataSource = stalls;
        }
    }
}

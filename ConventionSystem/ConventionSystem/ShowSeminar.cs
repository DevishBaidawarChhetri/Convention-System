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
using System.Data.Entity.Validation;

namespace ConventionSystem
{
    public partial class ShowSeminar : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public ShowSeminar()
        {
            InitializeComponent();
        }

        private void ViewSeminar_Load(object sender, EventArgs e)
        {
            LoadSeminar();
        }

        private void dgvSeminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dg_Seminar.Rows[e.RowIndex].Cells["SeminarId"].Value);
            if (dg_Seminar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string command = dg_Seminar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (command.ToLower() == "delete")
                {
                    try
                    {
                        if (MessageBox.Show("Do you want to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var seminar = db.Seminars.Where(s => s.SeminarId == id).Include(s => s.AudienceSeminars).Include(s => s.PresenterSeminars).Include(s => s.Room).FirstOrDefault();
                            db.Seminars.Remove(seminar);
                            db.SaveChanges();
                            MessageBox.Show("Seminar Successfully deleted");
                            LoadSeminar();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                else if (command.ToLower() == "edit")
                {
                    AddSeminar addSeminar = new AddSeminar(id);
                    addSeminar.Show();
                }
            }
        }
        private void LoadSeminar()
        {
            var seminars = (from s in db.Seminars select new { s.Room.Location, s.SeminarStartTime, s.Duration, s.SeminarId, s.SeminarTitle }).ToList();
            dg_Seminar.DataSource = seminars;
        }
    }
}

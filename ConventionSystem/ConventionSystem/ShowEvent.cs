using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConventionSystem
{
    
    public partial class ShowEvent : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public ShowEvent()
        {
            InitializeComponent();
        }

        private void dgvEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dg_Event.Rows[e.RowIndex].Cells["EventId"].Value);
            if (dg_Event.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string command = dg_Event.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (command.ToLower() == "delete")
                {
                    try
                    {
                        if (MessageBox.Show("Do you want to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var Event = db.Events.Where(ev => ev.EventId == id).Include(ev => ev.AttendeeEvents).Include(ev => ev.Room).FirstOrDefault();
                            db.Events.Remove(Event);
                            db.SaveChanges();
                            MessageBox.Show("Event Successfully deleted");
                            LoadEvent();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                else if (command.ToLower() == "edit")
                {
                    AddEvent addEvent = new AddEvent(id);
                    addEvent.Show();
                }
            }
        }
        private void ViewEvent_Load(object sender, EventArgs e)
        {
            LoadEvent();
        }

        private void LoadEvent()
        {
            var events = (from ev in db.Events select new { ev.Room.Location, ev.EventDate, ev.Duration, ev.EventId, ev.EventTitle, ev.EventDesc }).ToList();
            dg_Event.DataSource = events;
        }
    }
}

namespace ConventionSystem
{
    partial class RoomSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_ScheduleRoom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ScheduleRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_ScheduleRoom
            // 
            this.dg_ScheduleRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ScheduleRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_ScheduleRoom.Location = new System.Drawing.Point(0, 0);
            this.dg_ScheduleRoom.Name = "dg_ScheduleRoom";
            this.dg_ScheduleRoom.Size = new System.Drawing.Size(800, 450);
            this.dg_ScheduleRoom.TabIndex = 0;
            // 
            // RoomSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_ScheduleRoom);
            this.Name = "RoomSchedule";
            this.Text = "RoomSchedule";
            this.Load += new System.EventHandler(this.RoomSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ScheduleRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_ScheduleRoom;
    }
}
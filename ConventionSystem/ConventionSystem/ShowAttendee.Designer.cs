namespace ConventionSystem
{
    partial class ShowAttendee
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
            this.dg_AttendeeSchedule = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_AttendeeSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_AttendeeSchedule
            // 
            this.dg_AttendeeSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_AttendeeSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dg_AttendeeSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_AttendeeSchedule.Location = new System.Drawing.Point(0, 0);
            this.dg_AttendeeSchedule.Name = "dg_AttendeeSchedule";
            this.dg_AttendeeSchedule.Size = new System.Drawing.Size(794, 526);
            this.dg_AttendeeSchedule.TabIndex = 0;
            this.dg_AttendeeSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_AttendeeSchedule_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // ShowAttendee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 526);
            this.Controls.Add(this.dg_AttendeeSchedule);
            this.Name = "ShowAttendee";
            this.Text = "ShowAttendee";
            this.Load += new System.EventHandler(this.ViewAttendee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_AttendeeSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_AttendeeSchedule;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}
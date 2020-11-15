namespace ConventionSystem
{
    partial class EventSchedule
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
            this.dg_ScheduleEvent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ScheduleEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_ScheduleEvent
            // 
            this.dg_ScheduleEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ScheduleEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_ScheduleEvent.Location = new System.Drawing.Point(0, 0);
            this.dg_ScheduleEvent.Name = "dg_ScheduleEvent";
            this.dg_ScheduleEvent.Size = new System.Drawing.Size(800, 493);
            this.dg_ScheduleEvent.TabIndex = 0;
            // 
            // EventSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.dg_ScheduleEvent);
            this.Name = "EventSchedule";
            this.Text = "EventSchedule";
            this.Load += new System.EventHandler(this.EventSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ScheduleEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_ScheduleEvent;
    }
}
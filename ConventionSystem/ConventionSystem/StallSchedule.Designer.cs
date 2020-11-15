namespace ConventionSystem
{
    partial class StallSchedule
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
            this.dg_ScheduleStall = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ScheduleStall)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_ScheduleStall
            // 
            this.dg_ScheduleStall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ScheduleStall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_ScheduleStall.Location = new System.Drawing.Point(0, 0);
            this.dg_ScheduleStall.Name = "dg_ScheduleStall";
            this.dg_ScheduleStall.Size = new System.Drawing.Size(800, 450);
            this.dg_ScheduleStall.TabIndex = 0;
            // 
            // StallSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_ScheduleStall);
            this.Name = "StallSchedule";
            this.Text = "StallSchedule";
            this.Load += new System.EventHandler(this.StallSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ScheduleStall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_ScheduleStall;
    }
}
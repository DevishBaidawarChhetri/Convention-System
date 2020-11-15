namespace ConventionSystem
{
    partial class SeminarSchedule
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
            this.dg_ScheduleSeminar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ScheduleSeminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_ScheduleSeminar
            // 
            this.dg_ScheduleSeminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ScheduleSeminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_ScheduleSeminar.Location = new System.Drawing.Point(0, 0);
            this.dg_ScheduleSeminar.Name = "dg_ScheduleSeminar";
            this.dg_ScheduleSeminar.Size = new System.Drawing.Size(800, 450);
            this.dg_ScheduleSeminar.TabIndex = 0;
            // 
            // SeminarSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_ScheduleSeminar);
            this.Name = "SeminarSchedule";
            this.Text = "SeminarSchedule";
            this.Load += new System.EventHandler(this.SeminarSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ScheduleSeminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_ScheduleSeminar;
    }
}
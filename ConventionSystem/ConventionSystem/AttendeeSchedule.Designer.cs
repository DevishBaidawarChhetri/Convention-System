namespace ConventionSystem
{
    partial class AttendeeSchedule
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
            this.dg_AudienceSeminar = new System.Windows.Forms.DataGridView();
            this.dg_AttendeeStall = new System.Windows.Forms.DataGridView();
            this.dg_AttendeeEvent = new System.Windows.Forms.DataGridView();
            this.Seminar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dg_PresenterSeminar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_AudienceSeminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_AttendeeStall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_AttendeeEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_PresenterSeminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_AudienceSeminar
            // 
            this.dg_AudienceSeminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_AudienceSeminar.Location = new System.Drawing.Point(2, 24);
            this.dg_AudienceSeminar.Name = "dg_AudienceSeminar";
            this.dg_AudienceSeminar.Size = new System.Drawing.Size(760, 131);
            this.dg_AudienceSeminar.TabIndex = 0;
            // 
            // dg_AttendeeStall
            // 
            this.dg_AttendeeStall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_AttendeeStall.Location = new System.Drawing.Point(2, 541);
            this.dg_AttendeeStall.Name = "dg_AttendeeStall";
            this.dg_AttendeeStall.Size = new System.Drawing.Size(760, 159);
            this.dg_AttendeeStall.TabIndex = 1;
            // 
            // dg_AttendeeEvent
            // 
            this.dg_AttendeeEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_AttendeeEvent.Location = new System.Drawing.Point(2, 376);
            this.dg_AttendeeEvent.Name = "dg_AttendeeEvent";
            this.dg_AttendeeEvent.Size = new System.Drawing.Size(760, 119);
            this.dg_AttendeeEvent.TabIndex = 2;
            // 
            // Seminar
            // 
            this.Seminar.AutoSize = true;
            this.Seminar.Location = new System.Drawing.Point(332, 8);
            this.Seminar.Name = "Seminar";
            this.Seminar.Size = new System.Drawing.Size(93, 13);
            this.Seminar.TabIndex = 3;
            this.Seminar.Text = "Audience Seminar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stall";
            // 
            // dg_PresenterSeminar
            // 
            this.dg_PresenterSeminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_PresenterSeminar.Location = new System.Drawing.Point(2, 197);
            this.dg_PresenterSeminar.Name = "dg_PresenterSeminar";
            this.dg_PresenterSeminar.Size = new System.Drawing.Size(760, 137);
            this.dg_PresenterSeminar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Presenter Seminar";
            // 
            // AttendeeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_PresenterSeminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Seminar);
            this.Controls.Add(this.dg_AttendeeEvent);
            this.Controls.Add(this.dg_AttendeeStall);
            this.Controls.Add(this.dg_AudienceSeminar);
            this.MaximizeBox = false;
            this.Name = "AttendeeSchedule";
            this.Text = "AttendeeSchedule";
            this.Load += new System.EventHandler(this.AttendeeSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_AudienceSeminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_AttendeeStall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_AttendeeEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_PresenterSeminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_AudienceSeminar;
        private System.Windows.Forms.DataGridView dg_AttendeeStall;
        private System.Windows.Forms.DataGridView dg_AttendeeEvent;
        private System.Windows.Forms.Label Seminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg_PresenterSeminar;
        private System.Windows.Forms.Label label1;
    }
}
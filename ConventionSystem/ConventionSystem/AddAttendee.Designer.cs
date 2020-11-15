namespace ConventionSystem
{
    partial class AddAttendee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_AttendDays = new System.Windows.Forms.TextBox();
            this.cmb_TicketType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type of Ticket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Attend days";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(104, 298);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(117, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(158, 44);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(124, 20);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(158, 103);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(124, 20);
            this.txt_Email.TabIndex = 6;
            // 
            // txt_AttendDays
            // 
            this.txt_AttendDays.Location = new System.Drawing.Point(159, 229);
            this.txt_AttendDays.Name = "txt_AttendDays";
            this.txt_AttendDays.Size = new System.Drawing.Size(123, 20);
            this.txt_AttendDays.TabIndex = 8;
            // 
            // cmb_TicketType
            // 
            this.cmb_TicketType.FormattingEnabled = true;
            this.cmb_TicketType.Items.AddRange(new object[] {
            "Bronze",
            "Gold",
            "Platinum",
            "Diamond"});
            this.cmb_TicketType.Location = new System.Drawing.Point(163, 166);
            this.cmb_TicketType.Name = "cmb_TicketType";
            this.cmb_TicketType.Size = new System.Drawing.Size(121, 21);
            this.cmb_TicketType.TabIndex = 9;
            // 
            // AddAttendee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 395);
            this.Controls.Add(this.cmb_TicketType);
            this.Controls.Add(this.txt_AttendDays);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAttendee";
            this.Text = "AddAttendee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_AttendDays;
        private System.Windows.Forms.ComboBox cmb_TicketType;
    }
}
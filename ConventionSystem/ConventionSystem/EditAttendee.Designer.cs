namespace ConventionSystem
{
    partial class EditAttendee
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_AttendDays = new System.Windows.Forms.TextBox();
            this.cmb_Ticket = new System.Windows.Forms.ComboBox();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type of Ticket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Attend days";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(197, 57);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(135, 20);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(197, 120);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(135, 20);
            this.txt_Email.TabIndex = 5;
            // 
            // txt_AttendDays
            // 
            this.txt_AttendDays.Location = new System.Drawing.Point(196, 221);
            this.txt_AttendDays.Name = "txt_AttendDays";
            this.txt_AttendDays.Size = new System.Drawing.Size(136, 20);
            this.txt_AttendDays.TabIndex = 6;
            // 
            // cmb_Ticket
            // 
            this.cmb_Ticket.FormattingEnabled = true;
            this.cmb_Ticket.Items.AddRange(new object[] {
            "Bronze",
            "Gold",
            "Platinum",
            "Diamond"});
            this.cmb_Ticket.Location = new System.Drawing.Point(197, 173);
            this.cmb_Ticket.Name = "cmb_Ticket";
            this.cmb_Ticket.Size = new System.Drawing.Size(135, 21);
            this.cmb_Ticket.TabIndex = 7;
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(197, 272);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(135, 20);
            this.txt_ConfirmPassword.TabIndex = 8;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(178, 350);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(120, 23);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Location = new System.Drawing.Point(369, 272);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(75, 23);
            this.btn_ChangePassword.TabIndex = 10;
            this.btn_ChangePassword.Text = "Change Password";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Confirm password";
            // 
            // EditAttendee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.cmb_Ticket);
            this.Controls.Add(this.txt_AttendDays);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditAttendee";
            this.Text = "EditAttendee";
            this.Load += new System.EventHandler(this.EditAttendee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_AttendDays;
        private System.Windows.Forms.ComboBox cmb_Ticket;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.Label label5;
    }
}
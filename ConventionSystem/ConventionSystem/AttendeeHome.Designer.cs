namespace ConventionSystem
{
    partial class AttendeeHome
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
            this.btn_AttendeeSchedule = new System.Windows.Forms.Button();
            this.btn_EditProfile = new System.Windows.Forms.Button();
            this.btn_DeleteAccount = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AttendeeSchedule
            // 
            this.btn_AttendeeSchedule.Location = new System.Drawing.Point(63, 105);
            this.btn_AttendeeSchedule.Name = "btn_AttendeeSchedule";
            this.btn_AttendeeSchedule.Size = new System.Drawing.Size(147, 28);
            this.btn_AttendeeSchedule.TabIndex = 0;
            this.btn_AttendeeSchedule.Text = "View My Schedule";
            this.btn_AttendeeSchedule.UseVisualStyleBackColor = true;
            this.btn_AttendeeSchedule.Click += new System.EventHandler(this.btnAttendeeSchedule_Click);
            // 
            // btn_EditProfile
            // 
            this.btn_EditProfile.Location = new System.Drawing.Point(63, 41);
            this.btn_EditProfile.Name = "btn_EditProfile";
            this.btn_EditProfile.Size = new System.Drawing.Size(147, 26);
            this.btn_EditProfile.TabIndex = 1;
            this.btn_EditProfile.Text = "Edit My profile";
            this.btn_EditProfile.UseVisualStyleBackColor = true;
            this.btn_EditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btn_DeleteAccount
            // 
            this.btn_DeleteAccount.Location = new System.Drawing.Point(63, 166);
            this.btn_DeleteAccount.Name = "btn_DeleteAccount";
            this.btn_DeleteAccount.Size = new System.Drawing.Size(147, 27);
            this.btn_DeleteAccount.TabIndex = 2;
            this.btn_DeleteAccount.Text = "Delete my account?";
            this.btn_DeleteAccount.UseVisualStyleBackColor = true;
            this.btn_DeleteAccount.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(201, 242);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(67, 23);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AttendeeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 277);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_DeleteAccount);
            this.Controls.Add(this.btn_EditProfile);
            this.Controls.Add(this.btn_AttendeeSchedule);
            this.Name = "AttendeeHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AttendeeSchedule;
        private System.Windows.Forms.Button btn_EditProfile;
        private System.Windows.Forms.Button btn_DeleteAccount;
        private System.Windows.Forms.Button btn_Logout;
    }
}
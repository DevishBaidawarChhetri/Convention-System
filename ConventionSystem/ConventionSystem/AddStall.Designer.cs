namespace ConventionSystem
{
    partial class AddStall
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
            this.txt_Timehm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_AddStall = new System.Windows.Forms.Button();
            this.dp_StallDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_TimeFormat = new System.Windows.Forms.ComboBox();
            this.txt_Duration = new System.Windows.Forms.TextBox();
            this.txt_StallType = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dv_Stall = new System.Windows.Forms.DataGridView();
            this.btn_SaveAttendee = new System.Windows.Forms.Button();
            this.btn_BrowseAttendee = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_StallSize = new System.Windows.Forms.TextBox();
            this.txt_StallCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_Room = new System.Windows.Forms.ComboBox();
            this.cboSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_Stall)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Timehm
            // 
            this.txt_Timehm.Location = new System.Drawing.Point(77, 159);
            this.txt_Timehm.Name = "txt_Timehm";
            this.txt_Timehm.Size = new System.Drawing.Size(121, 20);
            this.txt_Timehm.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Time";
            // 
            // btn_AddStall
            // 
            this.btn_AddStall.Location = new System.Drawing.Point(92, 506);
            this.btn_AddStall.Name = "btn_AddStall";
            this.btn_AddStall.Size = new System.Drawing.Size(75, 23);
            this.btn_AddStall.TabIndex = 10;
            this.btn_AddStall.Text = "Add Stall";
            this.btn_AddStall.UseVisualStyleBackColor = true;
            this.btn_AddStall.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // dp_StallDate
            // 
            this.dp_StallDate.CustomFormat = "dd-MM-yyyy";
            this.dp_StallDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_StallDate.Location = new System.Drawing.Point(77, 124);
            this.dp_StallDate.Name = "dp_StallDate";
            this.dp_StallDate.Size = new System.Drawing.Size(96, 20);
            this.dp_StallDate.TabIndex = 1;
            // 
            // cmb_TimeFormat
            // 
            this.cmb_TimeFormat.FormattingEnabled = true;
            this.cmb_TimeFormat.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmb_TimeFormat.Location = new System.Drawing.Point(98, 197);
            this.cmb_TimeFormat.Name = "cmb_TimeFormat";
            this.cmb_TimeFormat.Size = new System.Drawing.Size(100, 21);
            this.cmb_TimeFormat.TabIndex = 3;
            // 
            // txt_Duration
            // 
            this.txt_Duration.Location = new System.Drawing.Point(98, 238);
            this.txt_Duration.Name = "txt_Duration";
            this.txt_Duration.Size = new System.Drawing.Size(111, 20);
            this.txt_Duration.TabIndex = 4;
            // 
            // txt_StallType
            // 
            this.txt_StallType.Location = new System.Drawing.Point(100, 327);
            this.txt_StallType.Name = "txt_StallType";
            this.txt_StallType.Size = new System.Drawing.Size(111, 20);
            this.txt_StallType.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dv_Stall);
            this.panel1.Controls.Add(this.btn_SaveAttendee);
            this.panel1.Location = new System.Drawing.Point(297, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 583);
            this.panel1.TabIndex = 31;
            // 
            // dv_Stall
            // 
            this.dv_Stall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_Stall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cboSelect});
            this.dv_Stall.Location = new System.Drawing.Point(0, 3);
            this.dv_Stall.Name = "dv_Stall";
            this.dv_Stall.Size = new System.Drawing.Size(488, 539);
            this.dv_Stall.TabIndex = 0;
            // 
            // btn_SaveAttendee
            // 
            this.btn_SaveAttendee.Location = new System.Drawing.Point(13, 548);
            this.btn_SaveAttendee.Name = "btn_SaveAttendee";
            this.btn_SaveAttendee.Size = new System.Drawing.Size(114, 23);
            this.btn_SaveAttendee.TabIndex = 8;
            this.btn_SaveAttendee.Text = "Save Exhibitor";
            this.btn_SaveAttendee.UseVisualStyleBackColor = true;
            this.btn_SaveAttendee.Click += new System.EventHandler(this.btnSaveAttendee_Click);
            // 
            // btn_BrowseAttendee
            // 
            this.btn_BrowseAttendee.Location = new System.Drawing.Point(111, 420);
            this.btn_BrowseAttendee.Name = "btn_BrowseAttendee";
            this.btn_BrowseAttendee.Size = new System.Drawing.Size(114, 23);
            this.btn_BrowseAttendee.TabIndex = 7;
            this.btn_BrowseAttendee.Text = "Browse Attendee";
            this.btn_BrowseAttendee.UseVisualStyleBackColor = true;
            this.btn_BrowseAttendee.Click += new System.EventHandler(this.btnBrowseAttendee_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Exhibitor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "(HH:MM)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "stall code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Time Format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Stall Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Size";
            // 
            // txt_StallSize
            // 
            this.txt_StallSize.Location = new System.Drawing.Point(98, 369);
            this.txt_StallSize.Name = "txt_StallSize";
            this.txt_StallSize.Size = new System.Drawing.Size(75, 20);
            this.txt_StallSize.TabIndex = 6;
            // 
            // txt_StallCode
            // 
            this.txt_StallCode.Location = new System.Drawing.Point(77, 76);
            this.txt_StallCode.Name = "txt_StallCode";
            this.txt_StallCode.Size = new System.Drawing.Size(121, 20);
            this.txt_StallCode.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Room";
            // 
            // cmb_Room
            // 
            this.cmb_Room.FormattingEnabled = true;
            this.cmb_Room.Location = new System.Drawing.Point(100, 279);
            this.cmb_Room.Name = "cmb_Room";
            this.cmb_Room.Size = new System.Drawing.Size(121, 21);
            this.cmb_Room.TabIndex = 46;
            // 
            // cboSelect
            // 
            this.cboSelect.HeaderText = "";
            this.cboSelect.Name = "cboSelect";
            // 
            // AddStall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 577);
            this.Controls.Add(this.cmb_Room);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_StallCode);
            this.Controls.Add(this.txt_StallSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Timehm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_AddStall);
            this.Controls.Add(this.dp_StallDate);
            this.Controls.Add(this.cmb_TimeFormat);
            this.Controls.Add(this.txt_Duration);
            this.Controls.Add(this.txt_StallType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_BrowseAttendee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddStall";
            this.Text = "AddStall";
            this.Load += new System.EventHandler(this.AddStall_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dv_Stall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Timehm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_AddStall;
        private System.Windows.Forms.DateTimePicker dp_StallDate;
        private System.Windows.Forms.ComboBox cmb_TimeFormat;
        private System.Windows.Forms.TextBox txt_Duration;
        private System.Windows.Forms.TextBox txt_StallType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dv_Stall;
        private System.Windows.Forms.Button btn_SaveAttendee;
        private System.Windows.Forms.Button btn_BrowseAttendee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_StallSize;
        private System.Windows.Forms.TextBox txt_StallCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_Room;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cboSelect;
    }
}
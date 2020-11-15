namespace ConventionSystem
{
    partial class AddEvent
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_BrowseAttendee = new System.Windows.Forms.Button();
            this.btn_SaveAttendee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg_Event = new System.Windows.Forms.DataGridView();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Duration = new System.Windows.Forms.TextBox();
            this.cmb_Room = new System.Windows.Forms.ComboBox();
            this.cmb_TimeFormat = new System.Windows.Forms.ComboBox();
            this.dp_EventDate = new System.Windows.Forms.DateTimePicker();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.btn_AddEvent = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Timehr = new System.Windows.Forms.TextBox();
            this.cboSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Event)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Format";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "(HH:MM)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Add Attendee";
            // 
            // btn_BrowseAttendee
            // 
            this.btn_BrowseAttendee.Location = new System.Drawing.Point(113, 438);
            this.btn_BrowseAttendee.Name = "btn_BrowseAttendee";
            this.btn_BrowseAttendee.Size = new System.Drawing.Size(114, 23);
            this.btn_BrowseAttendee.TabIndex = 8;
            this.btn_BrowseAttendee.Text = "Browse Attendee";
            this.btn_BrowseAttendee.UseVisualStyleBackColor = true;
            this.btn_BrowseAttendee.Click += new System.EventHandler(this.btnBrowseAttendee_Click);
            // 
            // btn_SaveAttendee
            // 
            this.btn_SaveAttendee.Location = new System.Drawing.Point(13, 548);
            this.btn_SaveAttendee.Name = "btn_SaveAttendee";
            this.btn_SaveAttendee.Size = new System.Drawing.Size(114, 23);
            this.btn_SaveAttendee.TabIndex = 9;
            this.btn_SaveAttendee.Text = "Save Attendee";
            this.btn_SaveAttendee.UseVisualStyleBackColor = true;
            this.btn_SaveAttendee.Click += new System.EventHandler(this.btnSaveAttendee_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dg_Event);
            this.panel1.Controls.Add(this.btn_SaveAttendee);
            this.panel1.Location = new System.Drawing.Point(298, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 583);
            this.panel1.TabIndex = 11;
            // 
            // dg_Event
            // 
            this.dg_Event.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Event.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cboSelect});
            this.dg_Event.Location = new System.Drawing.Point(3, 3);
            this.dg_Event.Name = "dg_Event";
            this.dg_Event.Size = new System.Drawing.Size(468, 539);
            this.dg_Event.TabIndex = 0;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(75, 62);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(156, 20);
            this.txt_Title.TabIndex = 0;
            // 
            // txt_Duration
            // 
            this.txt_Duration.Location = new System.Drawing.Point(88, 390);
            this.txt_Duration.Name = "txt_Duration";
            this.txt_Duration.Size = new System.Drawing.Size(100, 20);
            this.txt_Duration.TabIndex = 7;
            // 
            // cmb_Room
            // 
            this.cmb_Room.FormattingEnabled = true;
            this.cmb_Room.Location = new System.Drawing.Point(89, 346);
            this.cmb_Room.Name = "cmb_Room";
            this.cmb_Room.Size = new System.Drawing.Size(121, 21);
            this.cmb_Room.TabIndex = 6;
            // 
            // cmb_TimeFormat
            // 
            this.cmb_TimeFormat.FormattingEnabled = true;
            this.cmb_TimeFormat.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmb_TimeFormat.Location = new System.Drawing.Point(93, 296);
            this.cmb_TimeFormat.Name = "cmb_TimeFormat";
            this.cmb_TimeFormat.Size = new System.Drawing.Size(100, 21);
            this.cmb_TimeFormat.TabIndex = 5;
            // 
            // dp_EventDate
            // 
            this.dp_EventDate.CustomFormat = "dd-MM-yyyy";
            this.dp_EventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_EventDate.Location = new System.Drawing.Point(72, 223);
            this.dp_EventDate.Name = "dp_EventDate";
            this.dp_EventDate.Size = new System.Drawing.Size(96, 20);
            this.dp_EventDate.TabIndex = 3;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(107, 110);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(143, 89);
            this.txt_Description.TabIndex = 2;
            // 
            // btn_AddEvent
            // 
            this.btn_AddEvent.Location = new System.Drawing.Point(93, 510);
            this.btn_AddEvent.Name = "btn_AddEvent";
            this.btn_AddEvent.Size = new System.Drawing.Size(75, 23);
            this.btn_AddEvent.TabIndex = 10;
            this.btn_AddEvent.Text = "Add Event";
            this.btn_AddEvent.UseVisualStyleBackColor = true;
            this.btn_AddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Time";
            // 
            // txt_Timehr
            // 
            this.txt_Timehr.Location = new System.Drawing.Point(72, 267);
            this.txt_Timehr.Name = "txt_Timehr";
            this.txt_Timehr.Size = new System.Drawing.Size(100, 20);
            this.txt_Timehr.TabIndex = 4;
            // 
            // cboSelect
            // 
            this.cboSelect.HeaderText = "";
            this.cboSelect.Name = "cboSelect";
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 582);
            this.Controls.Add(this.txt_Timehr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_AddEvent);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.dp_EventDate);
            this.Controls.Add(this.cmb_TimeFormat);
            this.Controls.Add(this.cmb_Room);
            this.Controls.Add(this.txt_Duration);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_BrowseAttendee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Event)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_BrowseAttendee;
        private System.Windows.Forms.Button btn_SaveAttendee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dg_Event;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_Duration;
        private System.Windows.Forms.ComboBox cmb_Room;
        private System.Windows.Forms.ComboBox cmb_TimeFormat;
        private System.Windows.Forms.DateTimePicker dp_EventDate;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Button btn_AddEvent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Timehr;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cboSelect;
    }
}
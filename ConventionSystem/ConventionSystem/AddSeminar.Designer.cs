namespace ConventionSystem
{
    partial class AddSeminar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SaveAudiencePresenter = new System.Windows.Forms.Button();
            this.dg_Seminar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_BrowseAudience = new System.Windows.Forms.Button();
            this.btn_BrowsePresenter = new System.Windows.Forms.Button();
            this.btn_AddSeminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Timehr = new System.Windows.Forms.TextBox();
            this.cmb_TimeFormat = new System.Windows.Forms.ComboBox();
            this.cmb_Room = new System.Windows.Forms.ComboBox();
            this.txt_Duration = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dp_SeminarDate = new System.Windows.Forms.DateTimePicker();
            this.cboSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Seminar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_SaveAudiencePresenter);
            this.panel2.Controls.Add(this.dg_Seminar);
            this.panel2.Location = new System.Drawing.Point(366, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 521);
            this.panel2.TabIndex = 8;
            // 
            // btn_SaveAudiencePresenter
            // 
            this.btn_SaveAudiencePresenter.Location = new System.Drawing.Point(44, 487);
            this.btn_SaveAudiencePresenter.Name = "btn_SaveAudiencePresenter";
            this.btn_SaveAudiencePresenter.Size = new System.Drawing.Size(105, 23);
            this.btn_SaveAudiencePresenter.TabIndex = 9;
            this.btn_SaveAudiencePresenter.Text = "Save Presenter";
            this.btn_SaveAudiencePresenter.UseVisualStyleBackColor = true;
            this.btn_SaveAudiencePresenter.Click += new System.EventHandler(this.SaveAudiencePresenter_Click);
            // 
            // dg_Seminar
            // 
            this.dg_Seminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Seminar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cboSelect});
            this.dg_Seminar.Location = new System.Drawing.Point(4, 4);
            this.dg_Seminar.Name = "dg_Seminar";
            this.dg_Seminar.Size = new System.Drawing.Size(435, 477);
            this.dg_Seminar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Audience";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Presenter";
            // 
            // btn_BrowseAudience
            // 
            this.btn_BrowseAudience.Location = new System.Drawing.Point(127, 322);
            this.btn_BrowseAudience.Name = "btn_BrowseAudience";
            this.btn_BrowseAudience.Size = new System.Drawing.Size(117, 23);
            this.btn_BrowseAudience.TabIndex = 7;
            this.btn_BrowseAudience.Text = "Browse Audience";
            this.btn_BrowseAudience.UseVisualStyleBackColor = true;
            this.btn_BrowseAudience.Click += new System.EventHandler(this.btnBrowseAudience_Click);
            // 
            // btn_BrowsePresenter
            // 
            this.btn_BrowsePresenter.Location = new System.Drawing.Point(127, 384);
            this.btn_BrowsePresenter.Name = "btn_BrowsePresenter";
            this.btn_BrowsePresenter.Size = new System.Drawing.Size(117, 23);
            this.btn_BrowsePresenter.TabIndex = 8;
            this.btn_BrowsePresenter.Text = "Browse Presenter";
            this.btn_BrowsePresenter.UseVisualStyleBackColor = true;
            this.btn_BrowsePresenter.Click += new System.EventHandler(this.btnBrowsePresenter_Click);
            // 
            // btn_AddSeminar
            // 
            this.btn_AddSeminar.Location = new System.Drawing.Point(127, 458);
            this.btn_AddSeminar.Name = "btn_AddSeminar";
            this.btn_AddSeminar.Size = new System.Drawing.Size(93, 23);
            this.btn_AddSeminar.TabIndex = 10;
            this.btn_AddSeminar.Text = "Add Seminar";
            this.btn_AddSeminar.UseVisualStyleBackColor = true;
            this.btn_AddSeminar.Click += new System.EventHandler(this.btnAddSeminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "(HH:MM)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Time Format";
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(99, 36);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(200, 20);
            this.txt_Title.TabIndex = 0;
            // 
            // txt_Timehr
            // 
            this.txt_Timehr.Location = new System.Drawing.Point(99, 146);
            this.txt_Timehr.Name = "txt_Timehr";
            this.txt_Timehr.Size = new System.Drawing.Size(100, 20);
            this.txt_Timehr.TabIndex = 3;
            // 
            // cmb_TimeFormat
            // 
            this.cmb_TimeFormat.FormattingEnabled = true;
            this.cmb_TimeFormat.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmb_TimeFormat.Location = new System.Drawing.Point(136, 189);
            this.cmb_TimeFormat.Name = "cmb_TimeFormat";
            this.cmb_TimeFormat.Size = new System.Drawing.Size(93, 21);
            this.cmb_TimeFormat.TabIndex = 4;
            // 
            // cmb_Room
            // 
            this.cmb_Room.FormattingEnabled = true;
            this.cmb_Room.Location = new System.Drawing.Point(99, 228);
            this.cmb_Room.Name = "cmb_Room";
            this.cmb_Room.Size = new System.Drawing.Size(121, 21);
            this.cmb_Room.TabIndex = 5;
            // 
            // txt_Duration
            // 
            this.txt_Duration.Location = new System.Drawing.Point(99, 272);
            this.txt_Duration.Name = "txt_Duration";
            this.txt_Duration.Size = new System.Drawing.Size(100, 20);
            this.txt_Duration.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Duration);
            this.panel1.Controls.Add(this.dp_SeminarDate);
            this.panel1.Controls.Add(this.cmb_Room);
            this.panel1.Controls.Add(this.cmb_TimeFormat);
            this.panel1.Controls.Add(this.txt_Timehr);
            this.panel1.Controls.Add(this.txt_Title);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn_AddSeminar);
            this.panel1.Controls.Add(this.btn_BrowsePresenter);
            this.panel1.Controls.Add(this.btn_BrowseAudience);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 521);
            this.panel1.TabIndex = 7;
            // 
            // dp_SeminarDate
            // 
            this.dp_SeminarDate.CustomFormat = "dd-MM-yyyy";
            this.dp_SeminarDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_SeminarDate.Location = new System.Drawing.Point(99, 87);
            this.dp_SeminarDate.Name = "dp_SeminarDate";
            this.dp_SeminarDate.Size = new System.Drawing.Size(100, 20);
            this.dp_SeminarDate.TabIndex = 1;
            // 
            // cboSelect
            // 
            this.cboSelect.HeaderText = "";
            this.cboSelect.Name = "cboSelect";
            // 
            // AddSeminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddSeminar";
            this.Text = "AddSeminar";
            this.Load += new System.EventHandler(this.AddSeminar_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Seminar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dg_Seminar;
        private System.Windows.Forms.Button btn_SaveAudiencePresenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_BrowseAudience;
        private System.Windows.Forms.Button btn_BrowsePresenter;
        private System.Windows.Forms.Button btn_AddSeminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_Timehr;
        private System.Windows.Forms.ComboBox cmb_TimeFormat;
        private System.Windows.Forms.ComboBox cmb_Room;
        private System.Windows.Forms.TextBox txt_Duration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dp_SeminarDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cboSelect;
    }
}
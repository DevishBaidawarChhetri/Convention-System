namespace ConventionSystem
{
    partial class AddRoom
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
            this.btn_AddRoom = new System.Windows.Forms.Button();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.txt_Capacity = new System.Windows.Forms.TextBox();
            this.txt_Resources = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resources";
            // 
            // btn_AddRoom
            // 
            this.btn_AddRoom.Location = new System.Drawing.Point(109, 289);
            this.btn_AddRoom.Name = "btn_AddRoom";
            this.btn_AddRoom.Size = new System.Drawing.Size(75, 23);
            this.btn_AddRoom.TabIndex = 4;
            this.btn_AddRoom.Text = "Add";
            this.btn_AddRoom.UseVisualStyleBackColor = true;
            this.btn_AddRoom.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(143, 67);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(131, 20);
            this.txt_Location.TabIndex = 5;
            // 
            // txt_Capacity
            // 
            this.txt_Capacity.Location = new System.Drawing.Point(140, 131);
            this.txt_Capacity.Name = "txt_Capacity";
            this.txt_Capacity.Size = new System.Drawing.Size(131, 20);
            this.txt_Capacity.TabIndex = 6;
            // 
            // txt_Resources
            // 
            this.txt_Resources.Location = new System.Drawing.Point(140, 183);
            this.txt_Resources.Multiline = true;
            this.txt_Resources.Name = "txt_Resources";
            this.txt_Resources.Size = new System.Drawing.Size(131, 90);
            this.txt_Resources.TabIndex = 7;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 356);
            this.Controls.Add(this.txt_Resources);
            this.Controls.Add(this.txt_Capacity);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.btn_AddRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AddRoom;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.TextBox txt_Capacity;
        private System.Windows.Forms.TextBox txt_Resources;
    }
}
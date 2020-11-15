namespace ConventionSystem
{
    partial class ShowSeminar
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
            this.dg_Seminar = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Seminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Seminar
            // 
            this.dg_Seminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Seminar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Edit});
            this.dg_Seminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Seminar.Location = new System.Drawing.Point(0, 0);
            this.dg_Seminar.Name = "dg_Seminar";
            this.dg_Seminar.Size = new System.Drawing.Size(800, 450);
            this.dg_Seminar.TabIndex = 0;
            this.dg_Seminar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeminar_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // ShowSeminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_Seminar);
            this.Name = "ShowSeminar";
            this.Text = "ShowSeminar";
            this.Load += new System.EventHandler(this.ViewSeminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Seminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Seminar;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
    }
}
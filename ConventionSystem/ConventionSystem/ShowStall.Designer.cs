namespace ConventionSystem
{
    partial class ShowStall
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
            this.dg_Stall = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Stall)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Stall
            // 
            this.dg_Stall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Stall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Edit});
            this.dg_Stall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Stall.Location = new System.Drawing.Point(0, 0);
            this.dg_Stall.Name = "dg_Stall";
            this.dg_Stall.Size = new System.Drawing.Size(800, 450);
            this.dg_Stall.TabIndex = 0;
            this.dg_Stall.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStall_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
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
            // ShowStall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_Stall);
            this.Name = "ShowStall";
            this.Text = "ShowStall";
            this.Load += new System.EventHandler(this.ViewStall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Stall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Stall;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
    }
}
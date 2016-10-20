namespace TillSysForm
{
    partial class frmStaffList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffList));
            this.gridStaffList = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStaffList
            // 
            this.gridStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStaffList.Location = new System.Drawing.Point(28, 32);
            this.gridStaffList.Name = "gridStaffList";
            this.gridStaffList.ReadOnly = true;
            this.gridStaffList.Size = new System.Drawing.Size(360, 254);
            this.gridStaffList.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1, 312);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(422, 23);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmStaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(422, 333);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gridStaffList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStaffList";
            this.Text = "Till Sys(Staff List)";
            this.Load += new System.EventHandler(this.frmStaffList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStaffList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridStaffList;
        private System.Windows.Forms.Button btnBack;
    }
}
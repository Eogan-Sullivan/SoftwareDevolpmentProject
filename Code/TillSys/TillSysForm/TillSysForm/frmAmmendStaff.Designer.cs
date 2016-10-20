namespace TillSysForm
{
    partial class frmAmmendStaff
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
            System.Windows.Forms.Button btnUpdate;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmmendStaff));
            this.labLastName1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.gridStaff = new System.Windows.Forms.DataGridView();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.labStafID = new System.Windows.Forms.Label();
            this.labStaffID = new System.Windows.Forms.Label();
            this.txtLastName2 = new System.Windows.Forms.TextBox();
            this.labLastName = new System.Windows.Forms.Label();
            this.labFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStaff)).BeginInit();
            this.grpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(329, 92);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(90, 40);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labLastName1
            // 
            this.labLastName1.AutoSize = true;
            this.labLastName1.Location = new System.Drawing.Point(62, 48);
            this.labLastName1.Name = "labLastName1";
            this.labLastName1.Size = new System.Drawing.Size(53, 13);
            this.labLastName1.TabIndex = 8;
            this.labLastName1.Text = "Lastname";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(155, 45);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // gridStaff
            // 
            this.gridStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStaff.Location = new System.Drawing.Point(65, 82);
            this.gridStaff.Name = "gridStaff";
            this.gridStaff.ReadOnly = true;
            this.gridStaff.Size = new System.Drawing.Size(416, 150);
            this.gridStaff.TabIndex = 14;
            this.gridStaff.Visible = false;
            this.gridStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStaff_CellClick);
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.labStafID);
            this.grpUpdate.Controls.Add(this.labStaffID);
            this.grpUpdate.Controls.Add(this.txtLastName2);
            this.grpUpdate.Controls.Add(this.labLastName);
            this.grpUpdate.Controls.Add(btnUpdate);
            this.grpUpdate.Controls.Add(this.labFirstName);
            this.grpUpdate.Controls.Add(this.txtFirstName);
            this.grpUpdate.Location = new System.Drawing.Point(56, 261);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(425, 138);
            this.grpUpdate.TabIndex = 15;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Staff Information";
            this.grpUpdate.Visible = false;
            // 
            // labStafID
            // 
            this.labStafID.AutoSize = true;
            this.labStafID.Location = new System.Drawing.Point(154, 33);
            this.labStafID.Name = "labStafID";
            this.labStafID.Size = new System.Drawing.Size(0, 13);
            this.labStafID.TabIndex = 20;
            // 
            // labStaffID
            // 
            this.labStaffID.AutoSize = true;
            this.labStaffID.Location = new System.Drawing.Point(6, 33);
            this.labStaffID.Name = "labStaffID";
            this.labStaffID.Size = new System.Drawing.Size(40, 13);
            this.labStaffID.TabIndex = 19;
            this.labStaffID.Text = "StaffID";
            // 
            // txtLastName2
            // 
            this.txtLastName2.Location = new System.Drawing.Point(82, 92);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.Size = new System.Drawing.Size(81, 20);
            this.txtLastName2.TabIndex = 17;
            // 
            // labLastName
            // 
            this.labLastName.AutoSize = true;
            this.labLastName.Location = new System.Drawing.Point(6, 95);
            this.labLastName.Name = "labLastName";
            this.labLastName.Size = new System.Drawing.Size(53, 13);
            this.labLastName.TabIndex = 16;
            this.labLastName.Text = "Lastname";
            // 
            // labFirstName
            // 
            this.labFirstName.AutoSize = true;
            this.labFirstName.Location = new System.Drawing.Point(6, 65);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(54, 13);
            this.labFirstName.TabIndex = 15;
            this.labFirstName.Text = "FirstName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(82, 58);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(81, 20);
            this.txtFirstName.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(385, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 419);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(534, 22);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAmmendStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(534, 440);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.gridStaff);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.labLastName1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAmmendStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Till Sys(Ammend Staff)";
            ((System.ComponentModel.ISupportInitialize)(this.gridStaff)).EndInit();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLastName1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DataGridView gridStaff;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label labFirstName;
        private System.Windows.Forms.TextBox txtLastName2;
        private System.Windows.Forms.Label labLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labStafID;
        private System.Windows.Forms.Label labStaffID;
        private System.Windows.Forms.Button btnBack;

    }
}
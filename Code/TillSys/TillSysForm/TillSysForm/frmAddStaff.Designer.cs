namespace TillSysForm
{
    partial class frmAddStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStaff));
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStaffID = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.loginCode = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(169, 103);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(169, 157);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtStaffID
            // 
            this.txtStaffID.AutoSize = true;
            this.txtStaffID.Location = new System.Drawing.Point(234, 59);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(0, 13);
            this.txtStaffID.TabIndex = 5;
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(79, 110);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(52, 13);
            this.firstname.TabIndex = 6;
            this.firstname.Text = "Firstname";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(82, 164);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(49, 13);
            this.surname.TabIndex = 7;
            this.surname.Text = "Surname";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(134, 208);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(135, 40);
            this.btnReg.TabIndex = 8;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // loginCode
            // 
            this.loginCode.AutoSize = true;
            this.loginCode.Location = new System.Drawing.Point(40, 59);
            this.loginCode.Name = "loginCode";
            this.loginCode.Size = new System.Drawing.Size(91, 13);
            this.loginCode.TabIndex = 10;
            this.loginCode.Text = "GeneratedStaff Id";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(-3, 313);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(427, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(422, 333);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.loginCode);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Till Sys(Add Staff)";
            this.Load += new System.EventHandler(this.AddStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label txtStaffID;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label loginCode;
        private System.Windows.Forms.Button btnBack;

    }
}
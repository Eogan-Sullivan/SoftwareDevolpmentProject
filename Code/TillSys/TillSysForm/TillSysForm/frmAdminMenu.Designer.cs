namespace TillSysForm
{
    partial class frmAdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMenu));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegStaff = new System.Windows.Forms.Button();
            this.btnAmmendStaff = new System.Windows.Forms.Button();
            this.btnPrintStaff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 307);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(423, 27);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // btnRegStaff
            // 
            this.btnRegStaff.Location = new System.Drawing.Point(12, 239);
            this.btnRegStaff.Name = "btnRegStaff";
            this.btnRegStaff.Size = new System.Drawing.Size(99, 40);
            this.btnRegStaff.TabIndex = 1;
            this.btnRegStaff.Text = "Register Staff";
            this.btnRegStaff.UseVisualStyleBackColor = true;
            this.btnRegStaff.Click += new System.EventHandler(this.btnRegStaff_Click);
            // 
            // btnAmmendStaff
            // 
            this.btnAmmendStaff.Location = new System.Drawing.Point(155, 239);
            this.btnAmmendStaff.Name = "btnAmmendStaff";
            this.btnAmmendStaff.Size = new System.Drawing.Size(99, 40);
            this.btnAmmendStaff.TabIndex = 2;
            this.btnAmmendStaff.Text = "Amend  Staff";
            this.btnAmmendStaff.UseVisualStyleBackColor = true;
            this.btnAmmendStaff.Click += new System.EventHandler(this.ammendStaff_Click);
            // 
            // btnPrintStaff
            // 
            this.btnPrintStaff.Location = new System.Drawing.Point(294, 239);
            this.btnPrintStaff.Name = "btnPrintStaff";
            this.btnPrintStaff.Size = new System.Drawing.Size(99, 40);
            this.btnPrintStaff.TabIndex = 3;
            this.btnPrintStaff.Text = "Print Staff List";
            this.btnPrintStaff.UseVisualStyleBackColor = true;
            this.btnPrintStaff.Click += new System.EventHandler(this.printStaff_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(422, 333);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrintStaff);
            this.Controls.Add(this.btnAmmendStaff);
            this.Controls.Add(this.btnRegStaff);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Till Sys(Admin Menu)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRegStaff;
        private System.Windows.Forms.Button btnAmmendStaff;
        private System.Windows.Forms.Button btnPrintStaff;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
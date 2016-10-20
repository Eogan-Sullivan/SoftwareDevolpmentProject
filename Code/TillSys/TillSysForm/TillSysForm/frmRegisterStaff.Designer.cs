namespace TillSysForm
{
    partial class frmRegisterStaff
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
            this.statusBox = new System.Windows.Forms.CheckBox();
            this.staffName = new System.Windows.Forms.TextBox();
            this.submitName = new System.Windows.Forms.Button();
            this.generate_ID = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.finish_close = new System.Windows.Forms.Button();
            this.registerAnother = new System.Windows.Forms.Button();
            this.loginCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusBox
            // 
            this.statusBox.AutoSize = true;
            this.statusBox.Location = new System.Drawing.Point(308, 199);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(56, 17);
            this.statusBox.TabIndex = 0;
            this.statusBox.Text = "Active";
            this.statusBox.UseVisualStyleBackColor = true;
            // 
            // staffName
            // 
            this.staffName.Location = new System.Drawing.Point(190, 102);
            this.staffName.Name = "staffName";
            this.staffName.Size = new System.Drawing.Size(100, 20);
            this.staffName.TabIndex = 1;
            this.staffName.TextChanged += new System.EventHandler(this.staffName_TextChanged);
            // 
            // submitName
            // 
            this.submitName.Location = new System.Drawing.Point(308, 99);
            this.submitName.Name = "submitName";
            this.submitName.Size = new System.Drawing.Size(75, 23);
            this.submitName.TabIndex = 2;
            this.submitName.Text = "Submit";
            this.submitName.UseVisualStyleBackColor = true;
            // 
            // generate_ID
            // 
            this.generate_ID.AutoSize = true;
            this.generate_ID.Location = new System.Drawing.Point(265, 68);
            this.generate_ID.Name = "generate_ID";
            this.generate_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.generate_ID.Size = new System.Drawing.Size(25, 13);
            this.generate_ID.TabIndex = 5;
            this.generate_ID.Text = "533";
            this.generate_ID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(96, 105);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(52, 13);
            this.firstname.TabIndex = 6;
            this.firstname.Text = "Firstname";
            // 
            // finish_close
            // 
            this.finish_close.Location = new System.Drawing.Point(283, 245);
            this.finish_close.Name = "finish_close";
            this.finish_close.Size = new System.Drawing.Size(135, 40);
            this.finish_close.TabIndex = 8;
            this.finish_close.Text = "Save and Exit";
            this.finish_close.UseVisualStyleBackColor = true;
            this.finish_close.Click += new System.EventHandler(this.finish_close_Click);
            // 
            // registerAnother
            // 
            this.registerAnother.Location = new System.Drawing.Point(99, 245);
            this.registerAnother.Name = "registerAnother";
            this.registerAnother.Size = new System.Drawing.Size(135, 40);
            this.registerAnother.TabIndex = 9;
            this.registerAnother.Text = "Register Another";
            this.registerAnother.UseVisualStyleBackColor = true;
            this.registerAnother.Click += new System.EventHandler(this.registerAnother_Click);
            // 
            // loginCode
            // 
            this.loginCode.AutoSize = true;
            this.loginCode.Location = new System.Drawing.Point(96, 68);
            this.loginCode.Name = "loginCode";
            this.loginCode.Size = new System.Drawing.Size(91, 13);
            this.loginCode.TabIndex = 10;
            this.loginCode.Text = "GeneratedStaff Id";
            this.loginCode.Click += new System.EventHandler(this.loginCode_Click);
            // 
            // frmRegisterStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(525, 324);
            this.Controls.Add(this.loginCode);
            this.Controls.Add(this.registerAnother);
            this.Controls.Add(this.finish_close);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.generate_ID);
            this.Controls.Add(this.submitName);
            this.Controls.Add(this.staffName);
            this.Controls.Add(this.statusBox);
            this.Name = "frmRegisterStaff";
            this.Text = "AddStaff";
            this.Load += new System.EventHandler(this.AddStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox statusBox;
        private System.Windows.Forms.TextBox staffName;
        private System.Windows.Forms.Button submitName;
        private System.Windows.Forms.Label generate_ID;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Button finish_close;
        private System.Windows.Forms.Button registerAnother;
        private System.Windows.Forms.Label loginCode;

    }
}
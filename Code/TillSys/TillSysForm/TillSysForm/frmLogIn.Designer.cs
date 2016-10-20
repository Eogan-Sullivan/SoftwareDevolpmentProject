namespace TillSysForm
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.bc_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(143, 133);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(146, 20);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(143, 159);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(146, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.submit_Click);
            // 
            // bc_btn
            // 
            this.bc_btn.Location = new System.Drawing.Point(-6, 311);
            this.bc_btn.Name = "bc_btn";
            this.bc_btn.Size = new System.Drawing.Size(427, 23);
            this.bc_btn.TabIndex = 2;
            this.bc_btn.Text = "Back";
            this.bc_btn.UseVisualStyleBackColor = true;
            this.bc_btn.Click += new System.EventHandler(this.bc_btn_Click);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(422, 333);
            this.Controls.Add(this.bc_btn);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Till Sys(Log In Menu)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button bc_btn;
    }
}
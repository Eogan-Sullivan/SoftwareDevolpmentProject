namespace TillSysForm
{
    partial class frmItemMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemMenu));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAmmendItem = new System.Windows.Forms.Button();
            this.btnAddMenuItem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(-1, 311);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(424, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAmmendItem
            // 
            this.btnAmmendItem.Location = new System.Drawing.Point(311, 242);
            this.btnAmmendItem.Name = "btnAmmendItem";
            this.btnAmmendItem.Size = new System.Drawing.Size(99, 40);
            this.btnAmmendItem.TabIndex = 19;
            this.btnAmmendItem.Text = "Amend Item";
            this.btnAmmendItem.UseVisualStyleBackColor = true;
            this.btnAmmendItem.Click += new System.EventHandler(this.btnAmmendItem_Click);
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.Location = new System.Drawing.Point(8, 242);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.Size = new System.Drawing.Size(99, 40);
            this.btnAddMenuItem.TabIndex = 18;
            this.btnAddMenuItem.Text = "Add Item";
            this.btnAddMenuItem.UseVisualStyleBackColor = true;
            this.btnAddMenuItem.Click += new System.EventHandler(this.btnAddMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmItemMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(422, 333);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAmmendItem);
            this.Controls.Add(this.btnAddMenuItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmItemMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Till Sys(Item Menu)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAmmendItem;
        private System.Windows.Forms.Button btnAddMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace TillSysForm
{
    partial class frmSaleMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleMenu));
            this.btnMakeSale = new System.Windows.Forms.Button();
            this.btnRefundSale = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMakeSale
            // 
            this.btnMakeSale.Location = new System.Drawing.Point(12, 255);
            this.btnMakeSale.Name = "btnMakeSale";
            this.btnMakeSale.Size = new System.Drawing.Size(99, 40);
            this.btnMakeSale.TabIndex = 0;
            this.btnMakeSale.Text = "Make Sale";
            this.btnMakeSale.UseVisualStyleBackColor = true;
            this.btnMakeSale.Click += new System.EventHandler(this.btnMakeSale_Click);
            // 
            // btnRefundSale
            // 
            this.btnRefundSale.Location = new System.Drawing.Point(162, 255);
            this.btnRefundSale.Name = "btnRefundSale";
            this.btnRefundSale.Size = new System.Drawing.Size(99, 40);
            this.btnRefundSale.TabIndex = 1;
            this.btnRefundSale.Text = "Refund Sale";
            this.btnRefundSale.UseVisualStyleBackColor = true;
            this.btnRefundSale.Click += new System.EventHandler(this.btnRefundSale_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.Location = new System.Drawing.Point(311, 255);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(99, 40);
            this.btnViewSales.TabIndex = 2;
            this.btnViewSales.Text = "View Sales";
            this.btnViewSales.UseVisualStyleBackColor = true;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1, 310);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(422, 23);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmSaleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(422, 333);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewSales);
            this.Controls.Add(this.btnRefundSale);
            this.Controls.Add(this.btnMakeSale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSaleMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Till Sys(Sale Menu)";
          
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMakeSale;
        private System.Windows.Forms.Button btnRefundSale;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
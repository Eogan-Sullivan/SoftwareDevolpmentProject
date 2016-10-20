namespace TillSysForm
{
    partial class frmViewTotalSales
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bthBack = new System.Windows.Forms.Button();
            this.gridSales = new System.Windows.Forms.DataGridView();
            this.labCountSales = new System.Windows.Forms.Label();
            this.labAvgPrice = new System.Windows.Forms.Label();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.txtAvgPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bthBack
            // 
            this.bthBack.Location = new System.Drawing.Point(-3, 468);
            this.bthBack.Name = "bthBack";
            this.bthBack.Size = new System.Drawing.Size(572, 22);
            this.bthBack.TabIndex = 5;
            this.bthBack.Text = "Back";
            this.bthBack.UseVisualStyleBackColor = true;
            this.bthBack.Click += new System.EventHandler(this.bthBack_Click);
            // 
            // gridSales
            // 
            this.gridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSales.Location = new System.Drawing.Point(80, 27);
            this.gridSales.Name = "gridSales";
            this.gridSales.Size = new System.Drawing.Size(398, 223);
            this.gridSales.TabIndex = 3;
   
            // 
            // labCountSales
            // 
            this.labCountSales.AutoSize = true;
            this.labCountSales.Location = new System.Drawing.Point(131, 329);
            this.labCountSales.Name = "labCountSales";
            this.labCountSales.Size = new System.Drawing.Size(60, 13);
            this.labCountSales.TabIndex = 6;
            this.labCountSales.Text = "Total Sales";
            // 
            // labAvgPrice
            // 
            this.labAvgPrice.AutoSize = true;
            this.labAvgPrice.Location = new System.Drawing.Point(131, 358);
            this.labAvgPrice.Name = "labAvgPrice";
            this.labAvgPrice.Size = new System.Drawing.Size(98, 13);
            this.labAvgPrice.TabIndex = 7;
            this.labAvgPrice.Text = "Average Sale Price";
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Location = new System.Drawing.Point(235, 322);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.ReadOnly = true;
            this.txtTotalSales.Size = new System.Drawing.Size(100, 20);
            this.txtTotalSales.TabIndex = 9;
            // 
            // txtAvgPrice
            // 
            this.txtAvgPrice.Location = new System.Drawing.Point(235, 355);
            this.txtAvgPrice.Name = "txtAvgPrice";
            this.txtAvgPrice.ReadOnly = true;
            this.txtAvgPrice.Size = new System.Drawing.Size(100, 20);
            this.txtAvgPrice.TabIndex = 10;
            // 
            // frmViewTotalSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(567, 489);
            this.Controls.Add(this.txtAvgPrice);
            this.Controls.Add(this.txtTotalSales);
            this.Controls.Add(this.labAvgPrice);
            this.Controls.Add(this.labCountSales);
            this.Controls.Add(this.bthBack);
            this.Controls.Add(this.gridSales);
            this.Name = "frmViewTotalSales";
            this.Text = "ViewTotalSales";
            this.Load += new System.EventHandler(this.frmViewTotalSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bthBack;
        private System.Windows.Forms.DataGridView gridSales;
        private System.Windows.Forms.Label labCountSales;
        private System.Windows.Forms.Label labAvgPrice;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.TextBox txtAvgPrice;
    }
}
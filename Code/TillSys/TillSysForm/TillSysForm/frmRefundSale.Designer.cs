namespace TillSysForm
{
    partial class frmRefundSale
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
            System.Windows.Forms.Button btnRefund;
            this.bck_btn = new System.Windows.Forms.Button();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.txtSaleId = new System.Windows.Forms.TextBox();
            this.labSaleID = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.labItemId = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.gridSales = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labDesc = new System.Windows.Forms.Label();
            this.txtSaleId1 = new System.Windows.Forms.TextBox();
            btnRefund = new System.Windows.Forms.Button();
            this.grpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefund
            // 
            btnRefund.Location = new System.Drawing.Point(329, 92);
            btnRefund.Name = "btnRefund";
            btnRefund.Size = new System.Drawing.Size(90, 40);
            btnRefund.TabIndex = 13;
            btnRefund.Text = "Refund";
            btnRefund.UseVisualStyleBackColor = true;
            btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // bck_btn
            // 
            this.bck_btn.Location = new System.Drawing.Point(-3, 393);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(536, 23);
            this.bck_btn.TabIndex = 3;
            this.bck_btn.Text = "Back";
            this.bck_btn.UseVisualStyleBackColor = true;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.txtSaleId);
            this.grpUpdate.Controls.Add(this.labSaleID);
            this.grpUpdate.Controls.Add(this.txtPrice);
            this.grpUpdate.Controls.Add(this.labPrice);
            this.grpUpdate.Controls.Add(btnRefund);
            this.grpUpdate.Controls.Add(this.labItemId);
            this.grpUpdate.Controls.Add(this.txtItemId);
            this.grpUpdate.Location = new System.Drawing.Point(46, 231);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(425, 138);
            this.grpUpdate.TabIndex = 16;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Sale Information";
            this.grpUpdate.Visible = false;
            // 
            // txtSaleId
            // 
            this.txtSaleId.Enabled = false;
            this.txtSaleId.Location = new System.Drawing.Point(82, 26);
            this.txtSaleId.Name = "txtSaleId";
            this.txtSaleId.Size = new System.Drawing.Size(81, 20);
            this.txtSaleId.TabIndex = 20;
            // 
            // labSaleID
            // 
            this.labSaleID.AutoSize = true;
            this.labSaleID.Location = new System.Drawing.Point(6, 33);
            this.labSaleID.Name = "labSaleID";
            this.labSaleID.Size = new System.Drawing.Size(39, 13);
            this.labSaleID.TabIndex = 19;
            this.labSaleID.Text = "SaleID";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(82, 92);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(81, 20);
            this.txtPrice.TabIndex = 17;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(6, 95);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(69, 13);
            this.labPrice.TabIndex = 16;
            this.labPrice.Text = "Refund Price";
            // 
            // labItemId
            // 
            this.labItemId.AutoSize = true;
            this.labItemId.Location = new System.Drawing.Point(6, 65);
            this.labItemId.Name = "labItemId";
            this.labItemId.Size = new System.Drawing.Size(38, 13);
            this.labItemId.TabIndex = 15;
            this.labItemId.Text = "ItemID";
            // 
            // txtItemId
            // 
            this.txtItemId.Enabled = false;
            this.txtItemId.Location = new System.Drawing.Point(82, 58);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(81, 20);
            this.txtItemId.TabIndex = 14;
            // 
            // gridSales
            // 
            this.gridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSales.Location = new System.Drawing.Point(55, 66);
            this.gridSales.Name = "gridSales";
            this.gridSales.ReadOnly = true;
            this.gridSales.Size = new System.Drawing.Size(416, 150);
            this.gridSales.TabIndex = 17;
            this.gridSales.Visible = false;
            this.gridSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSales_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(383, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 23);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labDesc
            // 
            this.labDesc.AutoSize = true;
            this.labDesc.Location = new System.Drawing.Point(60, 43);
            this.labDesc.Name = "labDesc";
            this.labDesc.Size = new System.Drawing.Size(37, 13);
            this.labDesc.TabIndex = 18;
            this.labDesc.Text = "SaleId";
            // 
            // txtSaleId1
            // 
            this.txtSaleId1.Location = new System.Drawing.Point(153, 40);
            this.txtSaleId1.Name = "txtSaleId1";
            this.txtSaleId1.Size = new System.Drawing.Size(100, 20);
            this.txtSaleId1.TabIndex = 19;
            // 
            // frmRefundSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(532, 416);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSaleId1);
            this.Controls.Add(this.labDesc);
            this.Controls.Add(this.gridSales);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.bck_btn);
            this.Name = "frmRefundSale";
            this.Text = "RefundSale";
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bck_btn;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Label labSaleID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.DataGridView gridSales;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labDesc;
        private System.Windows.Forms.TextBox txtSaleId1;
        private System.Windows.Forms.TextBox txtSaleId;
        private System.Windows.Forms.Label labItemId;
    }
}
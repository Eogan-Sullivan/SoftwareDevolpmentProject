namespace TillSysForm
{
    partial class frmAmmenditem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmmenditem));
            this.gridItem = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.labQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.labItemID2 = new System.Windows.Forms.Label();
            this.labItemID = new System.Windows.Forms.Label();
            this.txtDesc2 = new System.Windows.Forms.TextBox();
            this.labDesc = new System.Windows.Forms.Label();
            this.labItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
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
            // gridItem
            // 
            this.gridItem.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItem.Location = new System.Drawing.Point(28, 69);
            this.gridItem.Name = "gridItem";
            this.gridItem.ReadOnly = true;
            this.gridItem.Size = new System.Drawing.Size(416, 150);
            this.gridItem.TabIndex = 15;
            this.gridItem.Visible = false;
            this.gridItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItem_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(348, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 18;
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.labQuantity);
            this.grpUpdate.Controls.Add(this.txtQuantity);
            this.grpUpdate.Controls.Add(this.txtPrice);
            this.grpUpdate.Controls.Add(this.labPrice);
            this.grpUpdate.Controls.Add(this.labItemID2);
            this.grpUpdate.Controls.Add(this.labItemID);
            this.grpUpdate.Controls.Add(this.txtDesc2);
            this.grpUpdate.Controls.Add(this.labDesc);
            this.grpUpdate.Controls.Add(btnUpdate);
            this.grpUpdate.Controls.Add(this.labItemName);
            this.grpUpdate.Controls.Add(this.txtItemName);
            this.grpUpdate.Location = new System.Drawing.Point(19, 241);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(425, 138);
            this.grpUpdate.TabIndex = 19;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Item Information";
            this.grpUpdate.Visible = false;
            // 
            // labQuantity
            // 
            this.labQuantity.AutoSize = true;
            this.labQuantity.Location = new System.Drawing.Point(201, 52);
            this.labQuantity.Name = "labQuantity";
            this.labQuantity.Size = new System.Drawing.Size(46, 13);
            this.labQuantity.TabIndex = 24;
            this.labQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(263, 49);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(81, 20);
            this.txtQuantity.TabIndex = 23;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(72, 106);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(81, 20);
            this.txtPrice.TabIndex = 22;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(6, 106);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(31, 13);
            this.labPrice.TabIndex = 21;
            this.labPrice.Text = "Price";
            // 
            // labItemID2
            // 
            this.labItemID2.AutoSize = true;
            this.labItemID2.Location = new System.Drawing.Point(137, 33);
            this.labItemID2.Name = "labItemID2";
            this.labItemID2.Size = new System.Drawing.Size(0, 13);
            this.labItemID2.TabIndex = 20;
            // 
            // labItemID
            // 
            this.labItemID.AutoSize = true;
            this.labItemID.Location = new System.Drawing.Point(6, 33);
            this.labItemID.Name = "labItemID";
            this.labItemID.Size = new System.Drawing.Size(38, 13);
            this.labItemID.TabIndex = 19;
            this.labItemID.Text = "ItemID";
            // 
            // txtDesc2
            // 
            this.txtDesc2.Location = new System.Drawing.Point(72, 77);
            this.txtDesc2.Name = "txtDesc2";
            this.txtDesc2.Size = new System.Drawing.Size(81, 20);
            this.txtDesc2.TabIndex = 17;
            // 
            // labDesc
            // 
            this.labDesc.AutoSize = true;
            this.labDesc.Location = new System.Drawing.Point(6, 80);
            this.labDesc.Name = "labDesc";
            this.labDesc.Size = new System.Drawing.Size(60, 13);
            this.labDesc.TabIndex = 16;
            this.labDesc.Text = "Description";
            // 
            // labItemName
            // 
            this.labItemName.AutoSize = true;
            this.labItemName.Location = new System.Drawing.Point(6, 56);
            this.labItemName.Name = "labItemName";
            this.labItemName.Size = new System.Drawing.Size(55, 13);
            this.labItemName.TabIndex = 15;
            this.labItemName.Text = "ItemName";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(73, 49);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(81, 20);
            this.txtItemName.TabIndex = 14;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(25, 28);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(35, 13);
            this.labName.TabIndex = 20;
            this.labName.Text = "Name";
            this.labName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(464, 23);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAmmenditem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(463, 419);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gridItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAmmenditem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Till Sys(Amend Item)";
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Label labItemID2;
        private System.Windows.Forms.Label labItemID;
        private System.Windows.Forms.TextBox txtDesc2;
        private System.Windows.Forms.Label labDesc;
        private System.Windows.Forms.TextBox txtItemName;
        public System.Windows.Forms.Label labItemName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.Label labQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnBack;
    }
}
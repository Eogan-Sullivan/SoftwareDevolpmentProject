namespace TillSysForm
{
    partial class frmAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddItem));
            this.txtOnMenu = new System.Windows.Forms.CheckBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labeItemName = new System.Windows.Forms.Label();
            this.labelItemDesc = new System.Windows.Forms.Label();
            this.labelItemPrice = new System.Windows.Forms.Label();
            this.labelItemQuan = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelItemID = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOnMenu
            // 
            this.txtOnMenu.AutoSize = true;
            this.txtOnMenu.Location = new System.Drawing.Point(301, 192);
            this.txtOnMenu.Name = "txtOnMenu";
            this.txtOnMenu.Size = new System.Drawing.Size(70, 17);
            this.txtOnMenu.TabIndex = 4;
            this.txtOnMenu.Text = "On Menu";
            this.txtOnMenu.UseVisualStyleBackColor = true;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(195, 84);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 5;
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.Location = new System.Drawing.Point(195, 110);
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.Size = new System.Drawing.Size(100, 20);
            this.txtItemDesc.TabIndex = 6;
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(195, 136);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(100, 20);
            this.txtItemPrice.TabIndex = 7;
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Location = new System.Drawing.Point(195, 166);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtItemQuantity.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(102, 188);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(193, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.submitItem_Click);
            // 
            // labeItemName
            // 
            this.labeItemName.AutoSize = true;
            this.labeItemName.Location = new System.Drawing.Point(104, 91);
            this.labeItemName.Name = "labeItemName";
            this.labeItemName.Size = new System.Drawing.Size(35, 13);
            this.labeItemName.TabIndex = 12;
            this.labeItemName.Text = "Name";
            // 
            // labelItemDesc
            // 
            this.labelItemDesc.AutoSize = true;
            this.labelItemDesc.Location = new System.Drawing.Point(104, 117);
            this.labelItemDesc.Name = "labelItemDesc";
            this.labelItemDesc.Size = new System.Drawing.Size(60, 13);
            this.labelItemDesc.TabIndex = 13;
            this.labelItemDesc.Text = "Description";
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.AutoSize = true;
            this.labelItemPrice.Location = new System.Drawing.Point(104, 143);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(31, 13);
            this.labelItemPrice.TabIndex = 14;
            this.labelItemPrice.Text = "Price";
            // 
            // labelItemQuan
            // 
            this.labelItemQuan.AutoSize = true;
            this.labelItemQuan.Location = new System.Drawing.Point(104, 169);
            this.labelItemQuan.Name = "labelItemQuan";
            this.labelItemQuan.Size = new System.Drawing.Size(46, 13);
            this.labelItemQuan.TabIndex = 15;
            this.labelItemQuan.Text = "Quantity";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(-4, 311);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(426, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.bckBtn_Click);
            // 
            // labelItemID
            // 
            this.labelItemID.AutoSize = true;
            this.labelItemID.Location = new System.Drawing.Point(104, 68);
            this.labelItemID.Name = "labelItemID";
            this.labelItemID.Size = new System.Drawing.Size(39, 13);
            this.labelItemID.TabIndex = 17;
            this.labelItemID.Text = "Item Id";
            // 
            // txtItemID
            // 
            this.txtItemID.AutoSize = true;
            this.txtItemID.Location = new System.Drawing.Point(256, 68);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(0, 13);
            this.txtItemID.TabIndex = 18;
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(422, 333);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.labelItemID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelItemQuan);
            this.Controls.Add(this.labelItemPrice);
            this.Controls.Add(this.labelItemDesc);
            this.Controls.Add(this.labeItemName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtItemQuantity);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.txtItemDesc);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtOnMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Till Sys(AddItem)";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox txtOnMenu;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemDesc;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.TextBox txtItemQuantity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labeItemName;
        private System.Windows.Forms.Label labelItemDesc;
        private System.Windows.Forms.Label labelItemPrice;
        private System.Windows.Forms.Label labelItemQuan;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelItemID;
        private System.Windows.Forms.Label txtItemID;
    }
}
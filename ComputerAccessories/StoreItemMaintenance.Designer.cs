namespace ComputerAccessories
{
    partial class StoreItemMaintenance
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
            this.btnMaintain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.cbxSubCategories = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.pbxSelectedItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMaintain
            // 
            this.btnMaintain.Location = new System.Drawing.Point(126, 334);
            this.btnMaintain.Name = "btnMaintain";
            this.btnMaintain.Size = new System.Drawing.Size(151, 23);
            this.btnMaintain.TabIndex = 69;
            this.btnMaintain.Text = "button1";
            this.btnMaintain.UseVisualStyleBackColor = true;
            this.btnMaintain.Click += new System.EventHandler(this.btnMaintain_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(283, 334);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 68;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(178, 15);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 67;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Location = new System.Drawing.Point(14, 20);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(40, 13);
            this.lblItemNumber.TabIndex = 56;
            this.lblItemNumber.Text = "Item #:";
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Location = new System.Drawing.Point(94, 17);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(78, 20);
            this.txtItemNumber.TabIndex = 57;
            this.txtItemNumber.Leave += new System.EventHandler(this.txtItemNumber_Leave);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(14, 46);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 58;
            this.lblCategory.Text = "Category:";
            // 
            // cbxCategories
            // 
            this.cbxCategories.Location = new System.Drawing.Point(94, 43);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(123, 21);
            this.cbxCategories.TabIndex = 59;
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Location = new System.Drawing.Point(14, 73);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(74, 13);
            this.lblSubCategory.TabIndex = 60;
            this.lblSubCategory.Text = "Sub-Category:";
            // 
            // cbxSubCategories
            // 
            this.cbxSubCategories.Location = new System.Drawing.Point(94, 70);
            this.cbxSubCategories.Name = "cbxSubCategories";
            this.cbxSubCategories.Size = new System.Drawing.Size(184, 21);
            this.cbxSubCategories.TabIndex = 61;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(14, 100);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(61, 13);
            this.lblItemName.TabIndex = 62;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(94, 97);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(264, 20);
            this.txtItemName.TabIndex = 63;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(14, 127);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblUnitPrice.TabIndex = 64;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(94, 124);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(264, 20);
            this.txtUnitPrice.TabIndex = 65;
            // 
            // pbxSelectedItem
            // 
            this.pbxSelectedItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxSelectedItem.Location = new System.Drawing.Point(370, 18);
            this.pbxSelectedItem.Name = "pbxSelectedItem";
            this.pbxSelectedItem.Size = new System.Drawing.Size(500, 339);
            this.pbxSelectedItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSelectedItem.TabIndex = 66;
            this.pbxSelectedItem.TabStop = false;
            // 
            // StoreItemMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 373);
            this.Controls.Add(this.btnMaintain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblItemNumber);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbxCategories);
            this.Controls.Add(this.lblSubCategory);
            this.Controls.Add(this.cbxSubCategories);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.pbxSelectedItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoreItemMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Accessories Store - Item Maintenance";
            this.Load += new System.EventHandler(this.StoreItemMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnMaintain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblItemNumber;
        public System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Label lblSubCategory;
        public System.Windows.Forms.ComboBox cbxSubCategories;
        private System.Windows.Forms.Label lblItemName;
        public System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblUnitPrice;
        public System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.PictureBox pbxSelectedItem;
    }
}
namespace ComputerAccessories
{
    partial class NewStoreItem
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnNewSubCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Location = new System.Drawing.Point(13, 18);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(40, 13);
            this.lblItemNumber.TabIndex = 39;
            this.lblItemNumber.Text = "Item #:";
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Location = new System.Drawing.Point(93, 15);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(78, 20);
            this.txtItemNumber.TabIndex = 40;
            this.txtItemNumber.Leave += new System.EventHandler(this.txtItemNumber_Leave);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(13, 44);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 41;
            this.lblCategory.Text = "Category:";
            // 
            // cbxCategories
            // 
            this.cbxCategories.Location = new System.Drawing.Point(93, 41);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(123, 21);
            this.cbxCategories.TabIndex = 42;
            this.cbxCategories.SelectedIndexChanged += new System.EventHandler(this.cbxCategories_SelectedIndexChanged);
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Location = new System.Drawing.Point(13, 71);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(74, 13);
            this.lblSubCategory.TabIndex = 43;
            this.lblSubCategory.Text = "Sub-Category:";
            // 
            // cbxSubCategories
            // 
            this.cbxSubCategories.Location = new System.Drawing.Point(93, 68);
            this.cbxSubCategories.Name = "cbxSubCategories";
            this.cbxSubCategories.Size = new System.Drawing.Size(184, 21);
            this.cbxSubCategories.TabIndex = 44;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(13, 98);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(61, 13);
            this.lblItemName.TabIndex = 45;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(93, 95);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(264, 20);
            this.txtItemName.TabIndex = 46;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(13, 125);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblUnitPrice.TabIndex = 47;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(93, 122);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(264, 20);
            this.txtUnitPrice.TabIndex = 48;
            // 
            // pbxSelectedItem
            // 
            this.pbxSelectedItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxSelectedItem.Location = new System.Drawing.Point(369, 16);
            this.pbxSelectedItem.Name = "pbxSelectedItem";
            this.pbxSelectedItem.Size = new System.Drawing.Size(500, 339);
            this.pbxSelectedItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSelectedItem.TabIndex = 49;
            this.pbxSelectedItem.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(202, 332);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 50;
            this.btnOK.Text = "OK";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(282, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(222, 40);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(75, 23);
            this.btnNewCategory.TabIndex = 52;
            this.btnNewCategory.Text = "New...";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // btnNewSubCategory
            // 
            this.btnNewSubCategory.Location = new System.Drawing.Point(282, 67);
            this.btnNewSubCategory.Name = "btnNewSubCategory";
            this.btnNewSubCategory.Size = new System.Drawing.Size(75, 23);
            this.btnNewSubCategory.TabIndex = 53;
            this.btnNewSubCategory.Text = "New...";
            this.btnNewSubCategory.UseVisualStyleBackColor = true;
            this.btnNewSubCategory.Click += new System.EventHandler(this.btnNewSubCategory_Click);
            // 
            // NewStoreItem
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(882, 370);
            this.Controls.Add(this.btnNewSubCategory);
            this.Controls.Add(this.btnNewCategory);
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
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewStoreItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Accessories Store - New Store Item";
            this.Load += new System.EventHandler(this.NewStoreItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Button btnNewSubCategory;
    }
}
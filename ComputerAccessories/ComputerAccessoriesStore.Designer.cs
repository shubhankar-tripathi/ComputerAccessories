namespace ComputerAccessories
{
    partial class ComputerAccessoriesStore
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
            this.lvwAvailableItems = new System.Windows.Forms.ListView();
            this.colItemNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdateStoreItem = new System.Windows.Forms.Button();
            this.btnDeleteStoreItem = new System.Windows.Forms.Button();
            this.lblAvailableItems = new System.Windows.Forms.Label();
            this.lbxSubCategories = new System.Windows.Forms.ListBox();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.lbxCategories = new System.Windows.Forms.ListBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewStoreItem = new System.Windows.Forms.Button();
            this.pbxSelectedItem = new System.Windows.Forms.PictureBox();
            this.btnDeleteAllStoreItems = new System.Windows.Forms.Button();
            this.btnCreateStoreItems = new System.Windows.Forms.Button();
            this.btnFirstItem = new System.Windows.Forms.Button();
            this.btnReplaceItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwAvailableItems
            // 
            this.lvwAvailableItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemNumber,
            this.colItemName,
            this.colUnitPrice});
            this.lvwAvailableItems.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAvailableItems.FullRowSelect = true;
            this.lvwAvailableItems.GridLines = true;
            this.lvwAvailableItems.Location = new System.Drawing.Point(386, 37);
            this.lvwAvailableItems.Name = "lvwAvailableItems";
            this.lvwAvailableItems.Size = new System.Drawing.Size(720, 202);
            this.lvwAvailableItems.TabIndex = 41;
            this.lvwAvailableItems.UseCompatibleStateImageBehavior = false;
            this.lvwAvailableItems.View = System.Windows.Forms.View.Details;
            this.lvwAvailableItems.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwAvailableItems_ItemSelectionChanged);
            // 
            // colItemNumber
            // 
            this.colItemNumber.Text = "Item #";
            this.colItemNumber.Width = 90;
            // 
            // colItemName
            // 
            this.colItemName.Text = "Item Name";
            this.colItemName.Width = 500;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Text = "Unit Price";
            this.colUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colUnitPrice.Width = 105;
            // 
            // btnUpdateStoreItem
            // 
            this.btnUpdateStoreItem.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStoreItem.Location = new System.Drawing.Point(18, 337);
            this.btnUpdateStoreItem.Name = "btnUpdateStoreItem";
            this.btnUpdateStoreItem.Size = new System.Drawing.Size(358, 57);
            this.btnUpdateStoreItem.TabIndex = 46;
            this.btnUpdateStoreItem.Text = "Update Store Item ...";
            this.btnUpdateStoreItem.UseVisualStyleBackColor = true;
            this.btnUpdateStoreItem.Click += new System.EventHandler(this.btnUpdateStoreItem_Click);
            // 
            // btnDeleteStoreItem
            // 
            this.btnDeleteStoreItem.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStoreItem.Location = new System.Drawing.Point(18, 400);
            this.btnDeleteStoreItem.Name = "btnDeleteStoreItem";
            this.btnDeleteStoreItem.Size = new System.Drawing.Size(358, 57);
            this.btnDeleteStoreItem.TabIndex = 45;
            this.btnDeleteStoreItem.Text = "Delete Store Item ...";
            this.btnDeleteStoreItem.UseVisualStyleBackColor = true;
            this.btnDeleteStoreItem.Click += new System.EventHandler(this.btnDeleteStoreItem_Click);
            // 
            // lblAvailableItems
            // 
            this.lblAvailableItems.AutoSize = true;
            this.lblAvailableItems.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableItems.Location = new System.Drawing.Point(393, 13);
            this.lblAvailableItems.Name = "lblAvailableItems";
            this.lblAvailableItems.Size = new System.Drawing.Size(136, 21);
            this.lblAvailableItems.TabIndex = 40;
            this.lblAvailableItems.Text = "Available Items";
            // 
            // lbxSubCategories
            // 
            this.lbxSubCategories.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSubCategories.FormattingEnabled = true;
            this.lbxSubCategories.ItemHeight = 18;
            this.lbxSubCategories.Location = new System.Drawing.Point(188, 37);
            this.lbxSubCategories.Name = "lbxSubCategories";
            this.lbxSubCategories.Size = new System.Drawing.Size(188, 202);
            this.lbxSubCategories.TabIndex = 39;
            this.lbxSubCategories.SelectedIndexChanged += new System.EventHandler(this.lbxSubCategories_SelectedIndexChanged);
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategory.Location = new System.Drawing.Point(188, 13);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(165, 21);
            this.lblSubCategory.TabIndex = 38;
            this.lblSubCategory.Text = "Item Sub-Category";
            // 
            // lbxCategories
            // 
            this.lbxCategories.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCategories.FormattingEnabled = true;
            this.lbxCategories.ItemHeight = 18;
            this.lbxCategories.Location = new System.Drawing.Point(18, 37);
            this.lbxCategories.Name = "lbxCategories";
            this.lbxCategories.Size = new System.Drawing.Size(164, 202);
            this.lbxCategories.TabIndex = 37;
            this.lbxCategories.SelectedIndexChanged += new System.EventHandler(this.lbxCategories_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(15, 13);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(127, 21);
            this.lblCategory.TabIndex = 36;
            this.lblCategory.Text = "Item Category";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(18, 529);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(358, 57);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewStoreItem
            // 
            this.btnNewStoreItem.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStoreItem.Location = new System.Drawing.Point(18, 274);
            this.btnNewStoreItem.Name = "btnNewStoreItem";
            this.btnNewStoreItem.Size = new System.Drawing.Size(358, 57);
            this.btnNewStoreItem.TabIndex = 43;
            this.btnNewStoreItem.Text = "New Store Item...";
            this.btnNewStoreItem.UseVisualStyleBackColor = true;
            this.btnNewStoreItem.Click += new System.EventHandler(this.btnNewStoreItem_Click);
            // 
            // pbxSelectedItem
            // 
            this.pbxSelectedItem.Location = new System.Drawing.Point(386, 241);
            this.pbxSelectedItem.Name = "pbxSelectedItem";
            this.pbxSelectedItem.Size = new System.Drawing.Size(720, 345);
            this.pbxSelectedItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSelectedItem.TabIndex = 42;
            this.pbxSelectedItem.TabStop = false;
            // 
            // btnDeleteAllStoreItems
            // 
            this.btnDeleteAllStoreItems.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllStoreItems.Location = new System.Drawing.Point(18, 466);
            this.btnDeleteAllStoreItems.Name = "btnDeleteAllStoreItems";
            this.btnDeleteAllStoreItems.Size = new System.Drawing.Size(358, 57);
            this.btnDeleteAllStoreItems.TabIndex = 47;
            this.btnDeleteAllStoreItems.Text = "Delete all Store Items";
            this.btnDeleteAllStoreItems.UseVisualStyleBackColor = true;
            this.btnDeleteAllStoreItems.Click += new System.EventHandler(this.btnDeleteAllStoreItems_Click);
            // 
            // btnCreateStoreItems
            // 
            this.btnCreateStoreItems.Location = new System.Drawing.Point(19, 592);
            this.btnCreateStoreItems.Name = "btnCreateStoreItems";
            this.btnCreateStoreItems.Size = new System.Drawing.Size(163, 23);
            this.btnCreateStoreItems.TabIndex = 48;
            this.btnCreateStoreItems.Text = "Create Store Items";
            this.btnCreateStoreItems.UseVisualStyleBackColor = true;
            this.btnCreateStoreItems.Click += new System.EventHandler(this.btnCreateStoreItems_Click);
            // 
            // btnFirstItem
            // 
            this.btnFirstItem.Location = new System.Drawing.Point(188, 592);
            this.btnFirstItem.Name = "btnFirstItem";
            this.btnFirstItem.Size = new System.Drawing.Size(91, 23);
            this.btnFirstItem.TabIndex = 49;
            this.btnFirstItem.Text = "First Item";
            this.btnFirstItem.UseVisualStyleBackColor = true;
            this.btnFirstItem.Click += new System.EventHandler(this.btnFirstItem_Click);
            // 
            // btnReplaceItem
            // 
            this.btnReplaceItem.Location = new System.Drawing.Point(285, 592);
            this.btnReplaceItem.Name = "btnReplaceItem";
            this.btnReplaceItem.Size = new System.Drawing.Size(91, 23);
            this.btnReplaceItem.TabIndex = 50;
            this.btnReplaceItem.Text = "Replace Item";
            this.btnReplaceItem.UseVisualStyleBackColor = true;
            this.btnReplaceItem.Click += new System.EventHandler(this.btnReplaceItem_Click);
            // 
            // ComputerAccessoriesStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 657);
            this.Controls.Add(this.btnReplaceItem);
            this.Controls.Add(this.btnFirstItem);
            this.Controls.Add(this.btnCreateStoreItems);
            this.Controls.Add(this.btnDeleteAllStoreItems);
            this.Controls.Add(this.lvwAvailableItems);
            this.Controls.Add(this.btnUpdateStoreItem);
            this.Controls.Add(this.btnDeleteStoreItem);
            this.Controls.Add(this.lblAvailableItems);
            this.Controls.Add(this.lbxSubCategories);
            this.Controls.Add(this.lblSubCategory);
            this.Controls.Add(this.lbxCategories);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewStoreItem);
            this.Controls.Add(this.pbxSelectedItem);
            this.MaximizeBox = false;
            this.Name = "ComputerAccessoriesStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Accessories Store - Store Items";
            this.Load += new System.EventHandler(this.ComputerAccessoriesStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwAvailableItems;
        private System.Windows.Forms.ColumnHeader colItemNumber;
        private System.Windows.Forms.ColumnHeader colItemName;
        private System.Windows.Forms.ColumnHeader colUnitPrice;
        private System.Windows.Forms.Button btnUpdateStoreItem;
        private System.Windows.Forms.Button btnDeleteStoreItem;
        private System.Windows.Forms.Label lblAvailableItems;
        private System.Windows.Forms.ListBox lbxSubCategories;
        private System.Windows.Forms.Label lblSubCategory;
        private System.Windows.Forms.ListBox lbxCategories;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewStoreItem;
        private System.Windows.Forms.PictureBox pbxSelectedItem;
        private System.Windows.Forms.Button btnDeleteAllStoreItems;
        private System.Windows.Forms.Button btnCreateStoreItems;
        private System.Windows.Forms.Button btnFirstItem;
        private System.Windows.Forms.Button btnReplaceItem;
    }
}


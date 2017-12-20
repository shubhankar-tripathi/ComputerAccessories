using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ComputerAccessories
{
    public partial class NewStoreItem : Form
    {
        public NewStoreItem()
        {
            InitializeComponent();
        }

        // Done
        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            Category editor = new Category();

            if (editor.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(editor.txtCategory.Text))
                {
                    string strCategory = editor.txtCategory.Text;

                    // Make sure the category is not yet in the list
                    if (cbxCategories.Items.Contains(strCategory))
                        MessageBox.Show(strCategory + " is already in the list.",
                                        "Computer Accessories Store",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        // Since this is a new category, add it to the combox box
                        cbxCategories.Items.Add(strCategory);
                        // Just in case the user wanted to use this new category
                        // select it
                        cbxCategories.Text = strCategory;
                    }
                }
            }
        }
        // Done
        private void btnNewSubCategory_Click(object sender, EventArgs e)
        {
            SubCategory editor = new SubCategory();

            if (editor.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(editor.txtSubCategory.Text))
                {
                    string strSubCategory = editor.txtSubCategory.Text;

                    if (cbxSubCategories.Items.Contains(strSubCategory))
                        MessageBox.Show(strSubCategory + " exists already.",
                                        "Computer Accessories Store",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        cbxSubCategories.Items.Add(strSubCategory);
                        cbxSubCategories.Text = strSubCategory;
                    }
                }
            }
        }
        // Done
        private void NewStoreItem_Load(object sender, EventArgs e)
        {
            StoreItems<StoreItem> items = new StoreItems<StoreItem>();
            BinaryFormatter bfmStoreItem = new BinaryFormatter();

            // This is the file that holds the list of items
            string strFileName = @"C:\Microsoft Visual C# Application Design\Computer Accessories Store\StoreItems.slm";

            if (File.Exists(strFileName))
            {
                using (FileStream stmStoreItem = new FileStream(strFileName,
                                                                FileMode.Open,
                                                                FileAccess.Read,
                                                                FileShare.Read))
                {
                    // Retrieve the list of items from file
                    items = (StoreItems<StoreItem>)bfmStoreItem.Deserialize(stmStoreItem);

                    // Display the categories in the combo box
                    for (int i = 0; i < items.Count; i++)
                    {
                        StoreItem item = (StoreItem)items[i];

                        if (!cbxCategories.Items.Contains(item.Category))
                            cbxCategories.Items.Add(item.Category);
                    }
                }
            }

            strFileName = @"C:\Microsoft Visual C# Application Design\Item.jpg";

            if (File.Exists(strFileName))
                pbxSelectedItem.Image = Image.FromFile(strFileName);
        }
        // Done
        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreItems<StoreItem> items = new StoreItems<StoreItem>();
            BinaryFormatter bfmStoreItem = new BinaryFormatter();

            // This is the file that holds the list of items
            string strFileName = @"C:\Microsoft Visual C# Application Design\Computer Accesories Store\StoreItems.slm";

            // If the file for the store inventory was created already, ...
            if (File.Exists(strFileName))
            {
                // ... open it
                using (FileStream stmStoreItem = new FileStream(strFileName,
                                                                FileMode.Open,
                                                                FileAccess.Read,
                                                                FileShare.Read))
                {
                    // Retrieve the list of items from file
                    items = (StoreItems<StoreItem>)bfmStoreItem.Deserialize(stmStoreItem);

                    // Display the categories in the combo box
                    for (int i = 0; i < items.Count; i++)
                    {
                        // Get store item based on its index
                        StoreItem item = (StoreItem)items[i];

                        // Get the item category
                        if (item.Category == cbxCategories.Text)
                        {
                            // Make sure the category is not yet in the Categories combo box
                            if (!cbxSubCategories.Items.Contains(item.SubCategory))
                                cbxSubCategories.Items.Add(item.SubCategory);
                        }
                    }
                }
            }
        }
        // Done
        private void txtItemNumber_Leave(object sender, EventArgs e)
        {
            string strFileName = @"C:\Microsoft Visual C# Application Design\" + txtItemNumber.Text + ".jpg";

            if (File.Exists(strFileName))
                pbxSelectedItem.Image = Image.FromFile(strFileName);
            else
                pbxSelectedItem.Image = Image.FromFile(@"C:\Microsoft Visual C# Application Design\Item.jpg");
        }
    }
}

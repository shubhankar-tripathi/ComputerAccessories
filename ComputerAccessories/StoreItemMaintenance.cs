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
    public partial class StoreItemMaintenance : Form
    {
        public StoreItemMaintenance()
        {
            InitializeComponent();
        }
        // Done
        private void txtItemNumber_Leave(object sender, EventArgs e)
        {
            btnFind_Click(sender, e);
        }
        // Done
        private void btnFind_Click(object sender, EventArgs e)
        {
            StoreItems<StoreItem> items = new StoreItems<StoreItem>();
            BinaryFormatter bfmStoreItem = new BinaryFormatter();

            // This is the file that holds the list of items
            string strFileName = @"C:\Microsoft Visual C# Application Design\Computer Accessories Store\StoreItems.slm";

            if (string.IsNullOrEmpty(txtItemNumber.Text))
            {
                MessageBox.Show("You must enter an item number.",
                                "Computer Accesories Store",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (File.Exists(strFileName))
            {
                using (FileStream stmStoreItem = new FileStream(strFileName,
                                                                FileMode.Open,
                                                                FileAccess.Read,
                                                                FileShare.Read))
                {
                    // Retrieve the list of items from file
                    items = (StoreItems<StoreItem>)bfmStoreItem.Deserialize(stmStoreItem);

                    foreach (StoreItem item in items)
                    {
                        if (item.ItemNumber == txtItemNumber.Text)
                        {
                            cbxCategories.Text = item.Category;
                            cbxSubCategories.Text = item.SubCategory;
                            txtItemName.Text = item.ItemName;
                            txtUnitPrice.Text = item.UnitPrice.ToString("F");
                        }
                    }
                }
            }

            strFileName = @"C:\Microsoft Visual C# Application Design\" + txtItemNumber.Text + ".jpg";

            if (File.Exists(strFileName))
                pbxSelectedItem.Image = Image.FromFile(strFileName);
            else
                pbxSelectedItem.Image = Image.FromFile(@"C:\Microsoft Visual C# Application Design\Item.jpg");
        }
        // Done
        private void btnMaintain_Click(object sender, EventArgs e)
        {
            bool itemFound = false;
            BinaryFormatter bfmStoreItem = new BinaryFormatter();
            StoreItems<StoreItem> items = new StoreItems<StoreItem>();

            // This is the file that holds the list of items
            string strFileName = @"C:\Microsoft Visual C# Application Design\Computer Accessories Store\StoreItems.slm";

            // Make sure the user entered a valid item number. Otherwise, don't do nothing
            if (string.IsNullOrEmpty(txtItemNumber.Text))
            {
                MessageBox.Show("You must enter an item number.",
                                "Computer Accessories Store",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Make sure the file that holds the store inventory was created already
            if (File.Exists(strFileName))
            {
                // If the inventory file exists, open it
                using (FileStream stmStoreItem = new FileStream(strFileName,
                                                                FileMode.Open,
                                                                FileAccess.Read,
                                                                FileShare.Read))
                {
                    // Retrieve the list of items from file
                    items = (StoreItems<StoreItem>)bfmStoreItem.Deserialize(stmStoreItem);

                    // Because we are using one dialog box for update and delete operations,
                    // first find out what operation is being conducted.
                    // If the user is trying to update a store item...
                    if (btnMaintain.Text == "Update Store Item")
                    {
                        // ... as a courtesy (just in case), ask the user to confirm the operation
                        if (MessageBox.Show("Are you sure you want to update this item?",
                                            "Computer Accessories Store",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            // Now that we know that the user wants to update the item, locate it
                            foreach (StoreItem item in items)
                            {
                                // If you find an item that has the number in the Item # text box, ...
                                if (item.ItemNumber == txtItemNumber.Text)
                                {
                                    // ... change the values of that item based on those on the dialog box
                                    item.Category = cbxCategories.Text;
                                    item.SubCategory = cbxSubCategories.Text;
                                    item.ItemName = txtItemName.Text;
                                    item.UnitPrice = double.Parse(txtUnitPrice.Text);
                                    // Since the item was found, make a note
                                    itemFound = true;
                                    // Now that the item has been found, stop looking for it
                                    break;
                                }
                            }

                            // As a courtesy, let the user know that the item was updated
                            MessageBox.Show("The item has been updated in the inventory.",
                                            "Computer Accessories Store",
                                            MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    else // if (btnMaintain.Text == "Delete Store Item")
                    {
                        // Make sure the user really wants to delete the item 
                        if (MessageBox.Show("Are you sure you want to delete this item?",
                                            "Computer Accessories Store",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            // Since the user really wants to delete the item, look for it
                            foreach (StoreItem item in items)
                            {
                                // If you find the item, ...
                                if (item.ItemNumber == txtItemNumber.Text)
                                {
                                    // ... remove it from the inventory
                                    items.Remove(item);
                                    // Let the user know that the item was deleted
                                    MessageBox.Show("The item has been removed from the inventory.",
                                                    "Computer Accessories Store",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    // Since the item was found and deleted, make a note
                                    itemFound = true;
                                    // Stop looking for the item
                                    break;
                                }
                            }
                        }
                    }
                }

                // Since there have been changes in the inventory (the StoreItems collection), update the file
                using (FileStream stmStoreItem = new FileStream(strFileName,
                                                                FileMode.Create,
                                                                FileAccess.Write,
                                                                FileShare.Write))
                {
                    bfmStoreItem.Serialize(stmStoreItem, items);
                }
            }

            // If the item was updated or deleted, close the dialog box
            if (itemFound == true)
                Close();
        }
        // Done
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StoreItemMaintenance_Load(object sender, EventArgs e)
        {

        }
    }
}

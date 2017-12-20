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
    public partial class ComputerAccessoriesStore : Form
    {
        StoreItems<StoreItem> allStoreItems;

        public ComputerAccessoriesStore()
        {
            InitializeComponent();
        }
        
        private void InitializeStoreItems()
        {
            lbxCategories.Items.Clear();
            lbxSubCategories.Items.Clear();
            lvwAvailableItems.Items.Clear();
            StoreItems<StoreItem> items = new StoreItems<StoreItem>();
            BinaryFormatter bfmStoreItem = new BinaryFormatter();

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
                   
                    allStoreItems = items;

                    // Display the categories in the combo box
                    foreach (StoreItem item in items)
                    {
                        if (!lbxCategories.Items.Contains(item.Category))
                            lbxCategories.Items.Add(item.Category);
                    }

                    pbxSelectedItem.Image = Image.FromFile(@"C:\Microsoft Visual C# Application Design\Item.jpg");
                }
            }
        }
        private void ComputerAccessoriesStore_Load(object sender, EventArgs e)
        {
            // If this directory and the sub-directory don't exist, create them
            //Directory.CreateDirectory(@"C:\Microsoft Visual C# Application Design\Computer Accessories Store");
            // If the default picture is available, show it.
            // If that picture is not found, the application is
            if (File.Exists(@"C:\Microsoft Visual C# ApplicationDesign\default.jpg"))
                pbxSelectedItem.Image = Image.FromFile(@"C:\Microsoft Visual C# ApplicationDesign\Item.jpg");
            // Initialize the Categories list box
            InitializeStoreItems();
        }

        private void btnNewStoreItem_Click(object sender, EventArgs e)
        {
            lbxSubCategories.Items.Clear();
            lvwAvailableItems.Items.Clear();
            NewStoreItem nsi = new NewStoreItem();

            StoreItem item = new StoreItem();
            StoreItems<StoreItem> items = new StoreItems<StoreItem>();
            BinaryFormatter bfmStoreItem = new BinaryFormatter();

            // This is the file that holds the list of items
            string strFileName = @"C:\Microsoft Visual C# Application Design\Computer Accessories Store\StoreItems.slm";

            if (nsi.ShowDialog() == DialogResult.OK)
            {
                // Make sure the user had selected a category
                if (string.IsNullOrEmpty(nsi.cbxCategories.Text))
                {
                    MessageBox.Show("You must specify the item's category.",
                                    "Computer Accessories Store",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Make sure the user had entered a name/description
                if (string.IsNullOrEmpty(nsi.txtItemName.Text))
                {
                    MessageBox.Show("You must enter the name (or a " +
                                    "short description) for the item.",
                                    "Computer Accessories Store",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Make sure the user had typed a price for the item
                if (string.IsNullOrEmpty(nsi.txtUnitPrice.Text))
                {
                    MessageBox.Show("You must enter the price of the item.",
                                    "Computer Accessories Store",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Before saving the new item, find out if there was
                // already a file that holds the list of items
                // If that file exists, open it and store its items 
                // in our StoreItems list
                if (File.Exists(strFileName))
                {
                    using (FileStream stmStoreItem = new FileStream(strFileName,
                                                        FileMode.Open,
                                            FileAccess.Read,
                                            FileShare.Read))
                    {
                        // Retrieve the list of items from file
                        items = (StoreItems<StoreItem>)bfmStoreItem.Deserialize(stmStoreItem);
                    }
                }

                // Create the accessory item
                item.ItemNumber = nsi.txtItemNumber.Text;
                item.Category = nsi.cbxCategories.Text;
                item.SubCategory = nsi.cbxSubCategories.Text;
                item.ItemName = nsi.txtItemName.Text;
                item.UnitPrice = double.Parse(nsi.txtUnitPrice.Text);

                // Call the Add method of our collection class to add the item
                items.Add(item);

                // Save the StoreItems collection
                using (FileStream stmStoreItem = new FileStream(strFileName,
                                                    FileMode.Create,
                                            FileAccess.Write,
                                            FileShare.Write))
                {
                    bfmStoreItem.Serialize(stmStoreItem, items);
                }
            }

            InitializeStoreItems();
        }
        // Done
        private void lvwAvailableItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string strFileName = @"C:\Microsoft Visual C# Application Design\" + e.Item.Text + ".jpg";

            if (File.Exists(strFileName))
                pbxSelectedItem.Image = Image.FromFile(strFileName);
            else
                pbxSelectedItem.Image = Image.FromFile(@"C:\Microsoft Visual C# Application Design\Item.jpg");
        }
        // Done
        private void lbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxSubCategories.Items.Clear();
            lvwAvailableItems.Items.Clear();

            BinaryFormatter bfmStoreItem = new BinaryFormatter();
            StoreItems<StoreItem> items = new StoreItems<StoreItem>();

            // This is the file that holds the list of items
            string strFileName = @"C:\Microsoft Visual C# Application Design\Solo Music Store\StoreItems.slm";

            if (File.Exists(strFileName))
            {
                using (FileStream stmStoreItem = new FileStream(strFileName,
                                     FileMode.Open,
                                     FileAccess.Read,
                                                     FileShare.Read))
                {
                    // Retrieve the list of items from file
                    items = (StoreItems<StoreItem>)bfmStoreItem.Deserialize(stmStoreItem);


                    // Display the sub-categories in the combo box
                    foreach (StoreItem item in items)
                    {
                        // Get only the sub-categories of the selected category
                        if (item.Category == lbxCategories.SelectedItem.ToString())
                        {
                            if (!lbxSubCategories.Items.Contains(item.SubCategory))
                                lbxSubCategories.Items.Add(item.SubCategory);
                        }
                    }
                }
            }
        }
        // Done
        private void lbxSubCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwAvailableItems.Items.Clear();

            BinaryFormatter bfmStoreItem = new BinaryFormatter();
            StoreItems<StoreItem> items = new StoreItems<StoreItem>();

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


                    // Display the sub-categories in the combo box
                    foreach (StoreItem item in items)
                    {
                        // Get only the sub-categories of the selected category
                        if (item.SubCategory == lbxSubCategories.SelectedItem.ToString())
                        {
                            ListViewItem lviStoreItem = new ListViewItem(item.ItemNumber);
                            lviStoreItem.SubItems.Add(item.ItemName);
                            lviStoreItem.SubItems.Add(item.UnitPrice.ToString("F"));

                            lvwAvailableItems.Items.Add(lviStoreItem);
                        }
                    }
                }
            }
        }
        // Done
        private void btnUpdateStoreItem_Click(object sender, EventArgs e)
        {
            StoreItemMaintenance sim = new StoreItemMaintenance();

            sim.btnMaintain.Text = "Update Store Item";
            sim.ShowDialog();

            InitializeStoreItems();
        }
        // Done
        private void btnDeleteStoreItem_Click(object sender, EventArgs e)
        {
            StoreItemMaintenance sim = new StoreItemMaintenance();

            sim.cbxCategories.Enabled = false;
            sim.cbxSubCategories.Enabled = false;
            sim.txtItemName.Enabled = false;
            sim.txtUnitPrice.Enabled = false;
            sim.btnMaintain.Text = "Delete Store Item";
            sim.ShowDialog();

            InitializeStoreItems();
        }
        // Done
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteAllStoreItems_Click(object sender, EventArgs e)
        {
            BinaryFormatter bfmStoreItem = new BinaryFormatter();
            StoreItems<StoreItem> items = new StoreItems<StoreItem>();

            string strFileName = @"C:\Microsoft Visual C# Application Design\Computer Accessories Store\StoreItems.slm";

            if (MessageBox.Show("Are you sure you want to delete all items?",
                                "Computer Accessories Store",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                items.Clear();
                MessageBox.Show("All items have been deleted from the inventory.",
                                "Computer Accessories Store",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                lvwAvailableItems.Items.Clear();
                lbxSubCategories.Items.Clear();
                lbxCategories.Items.Clear();

                if (File.Exists(strFileName))
                {
                    File.Delete(strFileName);
                }
            }
        }

        private void btnFirstItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bfmStoreItem = new BinaryFormatter();
            StoreItems<StoreItem> items = new StoreItems<StoreItem>();

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

                    StoreItem item = items.First(sc => sc.SubCategory == "Electric Guitars");

                    MessageBox.Show("Item #:\t\t" + item.ItemNumber + "\n" +
                                    "Category:\t" + item.Category + "\n" +
                                    "Sub-Category:\t" + item.SubCategory + "\n" +
                                    "Item Name:\t" + item.ItemName + "\n" +
                                    "Unit Price:\t" + item.UnitPrice.ToString("C"),
                                    "Computer Accessories Store",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnCreateStoreItems_Click(object sender, EventArgs e)
        {
            StoreItem item = new StoreItem();
            StoreItems<StoreItem> items = new StoreItems<StoreItem>();
            BinaryFormatter bfmStoreItem = new BinaryFormatter();

            // This is the file that holds the list of items
            string strFileName = @"C:\Microsoft Visual C# Application Design\Computer Accessories Store\StoreItems.slm";

            items.Add(new StoreItem("7MP-00011", "Mouse", "Wireless", "Arc Touch Bluetooth Mouse ", 69.95));
            items.Add(new StoreItem("485948", "Mouse", "Wired", "Amazon Basic", 20));
            items.Add(new StoreItem("920820", "Mouse", "Wireless", "Microsoft ergonomics", 80));
            items.Add(new StoreItem("406033", "Mouse", "Wired", "   Logitech", 45));
            items.Add(new StoreItem("358460", "Keyboard", "Wireless", "Logitech All-in-one", 50));
            items.Add(new StoreItem("724799", "Monitor", "1080p", "LG", 200));
            items.Add(new StoreItem("582693", "Thumbdrive", "USB 3.0", "Moserbaer", 15));
            items.Add(new StoreItem("350250", "Keyboard", "Wired", "Hp", 30));
            items.Add(new StoreItem("332085", "Thumbdrive", "USB 2.0", "SanDisk", 10));
            items.Add(new StoreItem("836360", "Thumbdrive", "USB 3.0", "SONY", 9));
         
            // Save the StoreItems collection
            using (FileStream stmStoreItem = new FileStream(strFileName,
                                                FileMode.Create,
                                        FileAccess.Write,
                                        FileShare.Write))
            {
                bfmStoreItem.Serialize(stmStoreItem, items);
            }
        }

        private void btnReplaceItem_Click(object sender, EventArgs e)
        {
            StoreItem selected = null;
            StoreItem item = new StoreItem();
            NewStoreItem nsi = new NewStoreItem();
            BinaryFormatter bfmStoreItem = new BinaryFormatter();
            StoreItems<StoreItem> items = new StoreItems<StoreItem>();
            string strFileName = @"C:\Microsoft Visual C# Application Design\Computer Accessories Store\StoreItems.slm";

            if (lvwAvailableItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item is selected.",
                                    "Computer Accessories Store",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (File.Exists(strFileName))
                {
                    using (FileStream stmStoreItem = new FileStream(strFileName,
                                                        FileMode.Open,
                                            FileAccess.Read,
                                            FileShare.Read))
                    {
                        // Retrieve the list of items from file
                        items = (StoreItems<StoreItem>)bfmStoreItem.Deserialize(stmStoreItem);

                        foreach (StoreItem itm in items)
                        {
                            if (itm.ItemNumber == lvwAvailableItems.SelectedItems[0].Text)
                            {
                                selected = itm;
                                break;
                            }
                        }
                    }
                }

                if (nsi.ShowDialog() == DialogResult.OK)
                {
                    // Make sure the user had selected a category
                    if (string.IsNullOrEmpty(nsi.cbxCategories.Text))
                    {
                        MessageBox.Show("You must specify the item's category.",
                                        "Computer Accessories Store",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Make sure the user had entered a name/description
                    if (string.IsNullOrEmpty(nsi.txtItemName.Text))
                    {
                        MessageBox.Show("You must enter the name (or a " +
                                        "short description) for the item.",
                                        "Computer Accessories Store",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Make sure the user had typed a price for the item
                    if (string.IsNullOrEmpty(nsi.txtUnitPrice.Text))
                    {
                        MessageBox.Show("You must enter the price of the item.",
                                        "Computer Accessories Store",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Create the  item
                    item.ItemNumber = nsi.txtItemNumber.Text;
                    item.Category = nsi.cbxCategories.Text;
                    item.SubCategory = nsi.cbxSubCategories.Text;
                    item.ItemName = nsi.txtItemName.Text;
                    item.UnitPrice = double.Parse(nsi.txtUnitPrice.Text);

                    // Call the Add method of our collection class to replace the item
                    items.Replace(selected, item);

                    // Save the StoreItems collection
                    using (FileStream stmStoreItem = new FileStream(strFileName,
                                                                    FileMode.Create,
                                                                    FileAccess.Write,
                                                                    FileShare.Write))
                    {
                        bfmStoreItem.Serialize(stmStoreItem, items);
                    }
                }
            }

            InitializeStoreItems();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerAccessories
{
    [Serializable]
    public class StoreItem
    {
        public string ItemNumber { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string ItemName { get; set; }
        public double UnitPrice { get; set; }

        public StoreItem()
        {
            ItemNumber = "000000";
            Category = "Miscellaneous";
            SubCategory = "Miscellaneous";
            ItemName = "Unknown";
            UnitPrice = 0.00D;
        }

        public StoreItem(string itmNumber, string category,
                         string subCategory, string name, double price)
        {
            ItemNumber = itmNumber;
            Category = category;
            SubCategory = subCategory;
            ItemName = name;
            UnitPrice = price;
        }

        public virtual bool Equals(StoreItem same)
        {
            if ((ItemNumber == same.ItemNumber) &&
                (Category == same.Category) &&
                (SubCategory == same.SubCategory) &&
                (ItemName == same.ItemName) &&
                (UnitPrice == same.UnitPrice))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return string.Format("Item #:\t{0}\nCategory:\t{1}\n" +
                                 "Item Type:\t{2}\nItem Name:\t{3}\n" +
                                 "Unit Price:\t{4}", ItemNumber, Category,
                                 SubCategory, ItemName, UnitPrice);
        }
    }
}

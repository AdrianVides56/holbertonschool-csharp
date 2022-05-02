using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary> Defines an item. </summary>
    public class Item : BaseClass
    {
        /// <summary> Item name </summary>
        public string name;
        /// <summary> Item description </summary>
        public string description;
        /// <summary> Item price </summary>
        public float price;

        /// <summary> Constructor </summary>
        public Item(string name="ItemName", string description="ItemDescription", float price=0.0f)
        {
            this.name = name;
            this.description = description;
            this.price = (float)Math.Round(price, 2);
            this.id = Guid.NewGuid().ToString();
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }

        /// <summary> Constructor </summary>
        public Item(string name, string description, float price,
            string id, DateTime date_created, DateTime date_updated)
        {
            this.name = name;
            this.description = description;
            this.price = (float)Math.Round(price, 2);
            this.id = id;
            this.date_created = date_created;
            this.date_updated = DateTime.Now;
        }
    }
}

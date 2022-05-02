using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary> Defines an invetory </summary>
    public class Inventory : BaseClass
    {
        /// <summary> User ID </summary>
        public string user_id;
        /// <summary> Item ID </summary>
        public string item_id;
        /// <summary> Item quantity </summary>
        public int quantity;

        /// <summary> Constructor </summary>
        public Inventory(string user_id="UserId", string item_id="ItemId", int quantity=1)
        {
            this.user_id = user_id;
            this.item_id = item_id;
            if (quantity < 1)
                this.quantity = quantity;
            this.id = Guid.NewGuid().ToString();
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }

        public Inventory(string user_id, string item_id, int quantity,
            string id, DateTime date_created, DateTime date_updated)
        {
            this.user_id = user_id;
            this.item_id = item_id;
            this.quantity = quantity;
            this.id = id;
            this.date_created = date_created;
            this.date_updated = DateTime.Now;
        }
    }
}
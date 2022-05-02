using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary> Defines a user. </summary>
    public class User : BaseClass
    {
        /// <summary> User name </summary>
        public string name;

        /// <summary> Constructor </summary>
        public User(string name="Name")
        {
            this.name = name;
            this.id = Guid.NewGuid().ToString();
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }

        /// <summary> Constructor </summary>
        public User(String name, String id, DateTime date_created, DateTime date_updated)
        {
            this.name = name;
            this.id = id;
            this.date_created = date_created;
            this.date_updated = DateTime.Now;
        }
    }
}
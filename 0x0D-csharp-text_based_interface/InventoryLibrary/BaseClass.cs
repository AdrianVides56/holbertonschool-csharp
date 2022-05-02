using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary> Base class for all classes in the InventoryLibrary. </summary>
    public class BaseClass
    {
        /// <summary> Object ID </summary>
        public string id;
        /// <summary> Date created </summary>
        public DateTime date_created;
        /// <summary> Date updated </summary>
        public DateTime date_updated;

        /// <summary> Converts object to Dictionary. </summary>
        public Dictionary<string, TValue> ToDictionary<TValue>(object obj)
        {       
            var json = JsonConvert.SerializeObject(obj);
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, TValue>>(json);   
            return dictionary;
        }
    }
}
using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>Serializes and deserializes JSON objects.</summary>
    public class JSONStorage
    {
        Dictionary<string, object> objects = new Dictionary<string, object>();
        string file_path = "../Storage/inventory_manager.json";

        /// <summary>Returns <see cref="objects"/>
        /// Where keys are `ClassName.id` and values are the objects
        /// .</summary>
        public Dictionary<string, object> All()
        {
            return this.objects;
        }

        /// <summary>Adds an object to <see cref="objects"/> dictionary.</summary>
        public void New(BaseClass obj)
        {
            var obj_dict = obj.ToDictionary<string>(obj);
            objects.Add(obj.GetType().Name + "." + obj.id, obj_dict);
        }

        /// <summary> Seriealizes <see cref="objects"/> to JSON and saves to JSON file.</summary>
        public void Save()
        {
            string json_string = JsonSerializer.Serialize(objects);
            if (!Directory.Exists("../Storage"))
            {
                Directory.CreateDirectory("../Storage");
            }
            using (FileStream fs = File.OpenWrite(file_path))
            {
                byte[] json_bytes = System.Text.Encoding.UTF8.GetBytes(json_string);
                fs.Write(json_bytes, 0, json_bytes.Length);
            }
        }

        /// <summary>Deserializes JSON file to <see cref="objects"/> dictionary.</summary>
        public void Load()
        {
            if (File.Exists(file_path))
            {
                string json_string = File.ReadAllText(file_path);
                objects = JsonSerializer.Deserialize(json_string, typeof(Dictionary<string, object>)) as Dictionary<string, object>;
            }
        }
    }
}
using System;
using System.Text.Json;
using System.Collections;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManager
{
    class Functions
    {
        JSONStorage jsonStorage = new JSONStorage();
        static string[] validClassNames = { "User",
                                            "Item",
                                            "Inventory" };
        List<string> classNames = new List<string>(validClassNames);
        /// <summary>Prints all class names of objects loaded in JSONstorage.</summary>
        public void ClassNames()
        {
            JSONStorage jsonStorage = new JSONStorage();
            List<string> classNames = new List<string>();
            jsonStorage.Load();
            Dictionary<string, object> all = jsonStorage.All();
            foreach (KeyValuePair<string, object> entry in all)
            {
                if (!classNames.Contains(entry.Key.Split('.')[0]))
                    classNames.Add(entry.Key.Split('.')[0]);
                else
                    continue;
            }
            foreach (string className in classNames)
            {
                Console.WriteLine($"{className}");
            }
        }

        /// <summary>
        /// All: Print all object
        /// All `ClassName`: Print all objects of the given class.</summary>
        public void All(string input)
        {
            string[] length = input.Split(' ');
            if (length.Length == 1)
            {
                jsonStorage.Load();
                Dictionary<string, object> all = jsonStorage.All();
                foreach (KeyValuePair<string, object> entry in all)
                    Console.WriteLine($"{entry}\n");
            }
            else
            {
                if (classNames.Contains(length[1]))
                {
                    JSONStorage jsonStorage = new JSONStorage();
                    jsonStorage.Load();
                    Dictionary<string, object> all = jsonStorage.All();
                    foreach (KeyValuePair<string, object> entry in all)
                    {
                        if (entry.Key.Split('.')[0] == length[1])
                            Console.WriteLine($"{entry}\n");
                    }
                }
                else
                    PrintError(0, length[1]);
            }
        }

        /// <summary>Creates a new object of the given ClassName.</summary>
        public void Create(string input)
        {
            string[] length = input.Split(' ');
            if (length.Length == 0 || input.Length == 6)
                PrintError(0, "");
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                switch (length[1])
                {
                    case "User":
                        Console.WriteLine("Enter User Name: ");
                        string name = Console.ReadLine();

                        User user = new User(name);
                        jsonStorage.New(user);
                        break;
                    case "Item":
                        Console.WriteLine("Enter Item Name: ");
                        string itemName = Console.ReadLine();

                        Console.WriteLine("Enter Item Description: ");
                        string itemDescription = Console.ReadLine();
                
                        Console.WriteLine("Enter Item Price: ");
                        string price = Console.ReadLine();
                        float itemPrice = float.Parse(price);

                        Item item = new Item(itemName, itemDescription, itemPrice);
                        jsonStorage.New(item);
                        break;
                    case "Inventory":
                        Inventory inventory;
                        bool checkUser, checkItem;

                        Console.WriteLine("Enter User Id:");
                        string userId = Console.ReadLine();

                        Console.WriteLine("Enter Item Id:");
                        string itemId = Console.ReadLine();

                        checkUser = CheckObject(userId);
                        if (!checkUser)
                            PrintError(1, userId);
                        checkItem = CheckObject(itemId);
                        if (!checkItem)
                            PrintError(1, itemId);

                        Console.WriteLine("Enter Item Quantity:");
                        string itemQuantity = Console.ReadLine();
                        int itemQuantityInt = int.Parse(itemQuantity);
                        if (checkItem && checkUser)
                        {
                            inventory = new Inventory(userId, itemId, itemQuantityInt);
                            jsonStorage.New(inventory);
                        }
                        else
                            PrintError(2, "Inventory");
                        break;
                    default:
                        PrintError(0, length[1]);
                        break;
                }
                Console.ResetColor();
                jsonStorage.Save();
            }
        }

        /// <summary>Shows an object of the given ClassName.</summary>
        public void Show(string input)
        {
            string[] length = input.Split(' ');

            if (length.Length == 0 || input.Length == 4)
                PrintError(0, "");
            else
            {
                if (!classNames.Contains(length[1]))
                    PrintError(0, length[1]);
                else if (length.Length != 3)
                    PrintError(1, "");
                else if (length.Length == 3)
                {
                    if (CheckObject(length[2]))
                    {
                        jsonStorage.Load();
                        Dictionary<string, object> all = jsonStorage.All();
                        foreach (KeyValuePair<string, object> entry in all)
                        {
                            if (entry.Key.Split('.')[0] == length[1] && entry.Key.Split('.')[1] == length[2])
                            foreach (string line in entry.Value.ToString().Split('\n'))
                                foreach (string line2 in line.Split(','))
                                    Console.WriteLine($"{line2}");
                        }
                    }
                    else
                        PrintError(1, length[2]);
                }
            }
        }

        public void Update()
        {
            Console.WriteLine("Updates an item.");
            Console.WriteLine("Coming soon...");
        }

        public void Delete()
        {
            Console.WriteLine("Deletes an item.");
            Console.WriteLine("Coming soon...");
        }

        public void Help()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Type one of the following commands:");
            Console.WriteLine("=================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("<ClassNames> ");
            Console.ResetColor();
            Console.WriteLine("show all ClassNames of objects");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("<All> ");
            Console.ResetColor();
            Console.WriteLine("show all objects");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("<All [ClassName]> ");
            Console.ResetColor();
            Console.WriteLine("show all objects of a ClassName");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("<Create [ClassName]> ");
            Console.ResetColor();
            Console.WriteLine("a new object");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("<Show [ClassName object_id]> ");
            Console.ResetColor();
            Console.WriteLine("an object");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("<Update [ClassName object_id]> ");
            Console.ResetColor();
            Console.WriteLine("an object");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("<Delete [ClassName object_id]> ");
            Console.ResetColor();
            Console.WriteLine("an object");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("<Exit> ");
            Console.ResetColor();
            Console.WriteLine("exit");
        }

        public void Exit()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Closing the program.");
            Console.ResetColor();
            Environment.Exit(0);
        }

        /// <summary>Prints different error messages.
        /// 0 - not valid object type
        /// 1 - no object with specified id found
        /// 2 - Could not create object</summary>
        public void PrintError(int num, string input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (num == 0)
            {
                Console.Write($"<{input}>");
                Console.ResetColor();
                Console.WriteLine(" is not a valid object type");
            }
            if (num == 1)
            {
                Console.Write($"Object <{input}>");
                Console.ResetColor();
                Console.WriteLine(" could not be found");
            }
            if (num == 2)
            {
                Console.Write($"Object <{input}>");
                Console.ResetColor();
                Console.WriteLine(" could not be created");
            }
        }

        /// <summary>Checks if an object exists.<summary>
        public bool CheckObject(string objId)
        {
            jsonStorage.Load();
            Dictionary<string, object> all = jsonStorage.All();
            foreach (KeyValuePair<string, object> entry in all)
            {
                if (entry.Key.Split('.')[1] == objId)
                    return true;
            }
            return false;
        }
    }
}

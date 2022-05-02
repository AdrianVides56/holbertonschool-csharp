using System;
using System.Text.Json;
using InventoryLibrary;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        JSONStorage jsonStorage = new JSONStorage();

        // Creates a new user
        User pablo = new User("pablo"), juan = new User("juan"), maria = new User("maria"), jose = new User("jose");
        //Console.WriteLine($"{user.id}");
        jsonStorage.New(pablo);
        jsonStorage.New(juan);
        jsonStorage.New(maria);
        jsonStorage.New(jose);

        // Creates a new item
        Item pencil = new Item("pencil", "it writes", 1f), eraser = new Item("eraser", "it erases", 2f),
            ruler = new Item("ruler", "it measures", 3f), pen = new Item("pen", "it inks xd", 3f);
        jsonStorage.New(pencil);
        jsonStorage.New(eraser);
        jsonStorage.New(ruler);
        jsonStorage.New(pen);

        // Creates a new inventory
        Inventory pabloInventory = new Inventory(pablo.id, pencil.id, 1);
        Inventory juanInventory = new Inventory(juan.id, eraser.id, 1);
        Inventory mariaInventory = new Inventory(maria.id, ruler.id, 1);
        Inventory joseInventory = new Inventory(jose.id, pen.id, 1);
        jsonStorage.New(pabloInventory);
        jsonStorage.New(juanInventory);
        jsonStorage.New(mariaInventory);
        jsonStorage.New(joseInventory);

        Console.WriteLine("-----------------------");

        jsonStorage.Save();
        System.Console.WriteLine("Saved");


        /* jsonStorage.Load();
        Dictionary<string, object> all = jsonStorage.All();
        foreach (KeyValuePair<string, object> entry in all)
        {
            Console.WriteLine($"{entry.Key}");
        } */
    }
}

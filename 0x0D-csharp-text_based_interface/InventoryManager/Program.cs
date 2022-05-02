using System;
using System.Collections;
using System.Collections.Generic;

namespace InventoryManager
{
    class Program
    {
        static string[] validCommands = { "ClassNames",
                                            "All",
                                            "Create",
                                            "Show",
                                            "Update",
                                            "Delete",
                                            "Help",
                                            "Exit" };

        /// <summary>Console application that demonstrates the use of the InventoryManager library.</summary>
        /// <param name="args">Command line arguments.</param>
        static void Main(string[] args)
        {
            string input;
            List<string> commands = new List<string>(validCommands);
            Functions functions = new Functions();
            PrintInitialMsg();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Text_based_interface$ ");
                Console.ResetColor();
                input = Console.ReadLine();
                string command = input.Split(' ')[0];
                if (commands.Contains(command))
                {
                    switch (command)
                    {
                        case "ClassNames":
                            functions.ClassNames();
                            break;
                        case "All":
                            functions.All(input);
                            break;
                        case "Create":
                            functions.Create(input);
                            break;
                        case "Show":
                            functions.Show(input);
                            break;
                        case "Update":
                            functions.Update();
                            break;
                        case "Delete":
                            functions.Delete();
                            break;
                        case "Help":
                            functions.Help();
                            break;
                        case "Exit":
                            functions.Exit();
                            break;
                    }
                }
                else
                {
                    PrintError("Invalid command", command);
                }
            }
        }

        static void PrintInitialMsg()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Inventory Manager");
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

        static void PrintError(string error, string input)
        {
            if (error.Equals("Invalid command"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(error + " ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"<{input}>.");
                Console.ResetColor();
                Console.Write(" Type");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" <Help> ");
                Console.ResetColor();
                Console.WriteLine("to see a list of available commands.");
            }

            Console.ResetColor();
        }
    }
}

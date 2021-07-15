using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int count = 0;
        string aux = null;
        bool check = false;
        foreach (var item in aStack)
            count++;
        Console.WriteLine($"Number of items: {count}");

        if (aStack.Count > 0)
            Console.WriteLine($"Top item: {aStack.Peek()}");
        else
            Console.WriteLine("Stack is empty");
        
        if (aStack.Contains(search))
        {
            Console.WriteLine($"Stack contains \"{search}\": True");
            check = true;
        }
        else
            Console.WriteLine($"Stack contains \"{search}\": False");

        while (check)
        {
            aux = aStack.Peek();
            if (String.Equals(search, aux))
                check = false;
            aStack.Pop();
        }

        aStack.Push(newItem);

        return aStack;
    }
}

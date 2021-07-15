using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int count = 0;
        string aux = null;
        foreach (var item in aStack)
            count++;
        Console.WriteLine($"Number of items: {count}");

        if (aStack.Count > 0)
            Console.WriteLine($"Top item: {aStack.Peek()}");
        else
            Console.WriteLine("Stack is empty");
        
        if (aStack.Contains(search))
        {
            Console.WriteLine($"Stack contains {search}: True");
            while (true)
            {
                aux = aStack.Peek();
                if (String.Equals(search, aux))
                    break;
                else
                    aStack.Pop();
            }
            aStack.Pop();
        }
        else
            Console.WriteLine($"Stack contains {search}: False");

        aStack.Push(newItem);

        return aStack;
    }
}

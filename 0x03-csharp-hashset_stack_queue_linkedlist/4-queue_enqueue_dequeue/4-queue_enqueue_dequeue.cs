using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int count = 0;
        bool check = true;

        foreach (string item in aQueue)
            count++;
        Console.WriteLine($"Number of items: {count}");

        if (count != 0)
            Console.WriteLine($"First item: {aQueue.Peek()}");
        else
            Console.WriteLine("Queue is empty");

        aQueue.Enqueue(newItem);

        if (aQueue.Contains(search))
        {
            Console.WriteLine($"Queue contains \"{search}\": True");
            while (check)
            {
                if (String.Equals(search, aQueue.Peek()))
                    check = false;
                aQueue.Dequeue();
            }
        }
        else
            Console.WriteLine($"Queue contains \"{search}\": False");
        
        return aQueue;
    }
}
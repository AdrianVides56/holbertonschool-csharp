using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> myList = new List<int>(size);

        for (int i = 0; i < myList.Capacity; i++)
        {
            myList.Add(i);
            if (i != myList.Capacity - 1)
                Console.Write(myList[i] + " ");
            else
                Console.Write(myList[i]);
        }
        Console.WriteLine("");
        return myList;
    }
}

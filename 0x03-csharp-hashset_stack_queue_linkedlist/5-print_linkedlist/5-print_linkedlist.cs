using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> MyLList = new LinkedList<int>();
        if (size < 0)
            return MyLList;

        for (int i = 0; i < size; i++)
            MyLList.AddLast(i);

        foreach (var i in MyLList)
            Console.WriteLine(i);

        return MyLList;
    }
}

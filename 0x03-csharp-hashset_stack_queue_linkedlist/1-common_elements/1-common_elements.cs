using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();

        foreach (var i in list1)
        {
            foreach (var j in list2)
            {
                if (i == j)
                    newList.Add(i);
            }
        }
        return newList;
    }
}
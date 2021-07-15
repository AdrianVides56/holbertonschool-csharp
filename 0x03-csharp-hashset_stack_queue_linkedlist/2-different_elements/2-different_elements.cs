using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>(list1);
        list2.ForEach(item => newList.Add(item));

        for (int i = newList.Count - 1; i >= 0; i--)
        {
            if (list1.Contains(newList[i]) && list2.Contains(newList[i]))
                newList.Remove(newList[i]);
        }
        newList.Sort();
        return newList;
    }
}
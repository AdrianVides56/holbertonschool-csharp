using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Capacity == 0 || myList == null)
            return -1;
        myList.Sort();
        return myList[myList.Count - 1];
    }
}

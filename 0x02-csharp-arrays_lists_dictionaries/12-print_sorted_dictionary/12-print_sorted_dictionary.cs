using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keysList = new List<string>();
        Dictionary<string, string> newDict = new Dictionary<string, string>();

        foreach (KeyValuePair<string, string> pair in myDict)
            keysList.Add(pair.Key);

        keysList.Sort();
        foreach (var key in keysList)
            newDict[key] = myDict[key];

        foreach (KeyValuePair<string, string> pair in newDict)
            Console.WriteLine($"{pair.Key}: {pair.Value}");
    }
}

using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        /* if (myDict[key])
        {

        } */
        myDict.Remove(key);

        return myDict;
    }
}

using System;
using System.Collections.Generic;

namespace Text
{
    public class Str
    {
        public static int UniqueChar(string s)
        {
            int aux = 0;
            List<int> check = new List<int>();

            for (int idx = 0; idx < s.Length; idx++)
            {
                aux = idx + 1;
                if (!check.Contains(s[idx]))
                {
                    check.Add(s[idx]);
                    while (aux < s.Length)
                    {
                        if (s[aux] == s[idx])
                            break;
                        if (aux == s.Length - 1)
                            return idx;
                        aux++;
                    }
                    if (idx == s.Length - 1)
                            return idx;
                }
            }
            return -1;
        }
    }
}

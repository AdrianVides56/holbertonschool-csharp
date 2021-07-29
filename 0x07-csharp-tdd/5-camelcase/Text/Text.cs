using System;

namespace Text
{
    public class Str
    {
        public static int CamelCase(string s)
        {
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int count = 0;

            if (s.Length <= 0)
                return count;

            for (int i = 1; i < s.Length; i++)
            {
                if (upper.IndexOf(s[i]) != -1)
                    count++;
            }

            if (s.Length == 1 && "abcdefghijklmnopqrstuvwxyz".IndexOf(s[0]) == -1)
                return 0;
            return count + 1;
        }
    }
}

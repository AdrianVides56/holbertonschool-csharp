using System;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();

            for (int i = 0, j = s.Length - 1; i < s.Length; i++)
            {
                if (!Char.IsLetterOrDigit(s[i]) || !Char.IsLetterOrDigit(s[j]))
                    continue;
                else if (s[i] != s[j])
                    return false;
                j--;
            }
            return true;
        }
    }
}

using System;

namespace Leetcode.Array
{
    public class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            s = String.Concat(s.OrderBy(s => s));
            t = String.Concat(t.OrderBy(s => s));

            return s == t;

        }
    }
}

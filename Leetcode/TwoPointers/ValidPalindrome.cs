using System.Text.RegularExpressions;

namespace Leetcode.TwoPointers
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            s = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();

            int start = 0;
            int end = s.Length - 1;

            for(int i = 0; i < s.Length; i++)
            {
                if(start <= end)
                {
                    if (s[start] != s[end])
                    {
                        return false;
                    }
                }
                start += 1;
                end -= 1;
            }

            return true;
        }
    }
}

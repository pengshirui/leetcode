namespace LeetCode.Palindrome.LongestPalindrome
{
    using System;

    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            var start = 0;
            var len = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var (l1, l2) = Max(s, i, i);
                var (r1, r2) = Max(s, i, i + 1);
                var max = Math.Max(l2, r2);
                if (max > len)
                {
                    len = max;
                    start = l2 > r2 ? l1 : r1;
                }
            }
            return s.Substring(start, len);
        }


        (int, int) Max(string s, int l, int r)
        {
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }

            return (l + 1, r - l - 1);
        }
    }
}

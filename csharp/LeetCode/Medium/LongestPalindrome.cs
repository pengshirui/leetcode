namespace LeetCode.Medium.LongestPalindrome
{
    using System;

    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            var start = 0;
            var maxLen = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var l1 = ExpandAroundCenter(s, i, i);
                var l2 = ExpandAroundCenter(s, i, i + 1);
                var len = Math.Max(l1, l2);
                if (len > maxLen)
                {
                    maxLen = len;
                    start = i - (len - 1) / 2;
                }
            }
            return s.Substring(start, maxLen);
        }

        int ExpandAroundCenter(string s, int l, int r)
        {
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }
            // stop at "s[l] != s[r]" so remove the length by 1
            return r - l - 1;
        }
    }
}

namespace LeetCode.Medium
{
    using System;
    using System.Collections.Generic;

    public partial class Solution
    {
        public int LengthOfLongestSubstringTwoDistinct(string s)
        {
            if (s.Length < 3)
            {
                return s.Length;
            }
            var l = 0;
            var r = 0;
            var ans = 0;
            var kv = new Dictionary<char, int>();
            var count = 0;
            while (r < s.Length)
            {
                kv[s[r]] = kv.GetValueOrDefault(s[r], 0) + 1;
                if (kv[s[r]] == 1)
                    count++;
                if (count <= 2)
                    ans = Math.Max(r - l + 1, ans);
                while (count > 2)
                {
                    kv[s[l]]--;
                    if (kv[s[l]] == 0)
                        count--;
                    l++;
                }
                r++;
            }
            return ans;
        }
    }
}

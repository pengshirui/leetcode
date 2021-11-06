using System.Collections.Generic;
using System;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var set = new HashSet<char>();
            var ans = 0;
            var l = 0;
            var r = 0;
            while (r < s.Length)
            {
                while (set.Contains(s[r]))
                {
                    set.Remove(s[l]);
                    l++;
                }
                set.Add(s[r]);
                ans = Math.Max(set.Count, ans);
                r++;
            }

            return ans;
        }
    }
}

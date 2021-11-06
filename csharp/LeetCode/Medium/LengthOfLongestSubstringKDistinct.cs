using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            var dict = new Dictionary<char, int>();
            var maxLen = 0;
            var left = 0;
            var right = 0;
            while (right < s.Length)
            {
                if (dict.ContainsKey(s[right]))
                {
                    dict[s[right]] = right++;
                }
                else
                {
                    dict[s[right]] = right++;
                }

                if (dict.Count == k + 1)
                {
                    // get the left most character stored in the map.
                    var idx = dict.Values.Min();
                    dict.Remove(s[idx]);
                    left = idx + 1;
                }

                maxLen = Math.Max(maxLen, right - left);
            }

            return maxLen;
        }
    }
}

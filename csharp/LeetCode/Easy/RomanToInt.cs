﻿using System.Collections.Generic;

namespace LeetCode.Easy
{
    public partial class Solution
    {
        Dictionary<char, int> kv = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        public int RomanToInt(string s)
        {
            var result = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (i + 1 == s.Length)
                {
                    // last index
                    result += this.kv[s[i]];
                }
                else if (this.kv[s[i]] < this.kv[s[i + 1]])
                {
                    result -= this.kv[s[i]];
                }
                else
                {
                    result += this.kv[s[i]];
                }

            }
            return result;
        }
    }
}

namespace LeetCode.Easy.CountBinarySubstrings
{
    using System;

    public class Solution
    {
        public int CountBinarySubstrings(string s)
        {
            var cur = 1;
            var pre = 0;
            var result = 0;
            for (var i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == s[i])
                {
                    cur++;
                }
                else
                {
                    result += Math.Min(pre, cur);
                    pre = cur;
                    cur = 1;
                }
            }
            return result + Math.Min(pre, cur);
        }
    }
}

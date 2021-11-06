namespace LeetCode.Hard
{
    using System;

    public partial class Solution
    {
        public int LongestValidParentheses(string s)
        {
            var maxLen = 0;
            var memo = new int[s.Length];
            for (var i = 1; i < s.Length; i++)
            {
                if (s[i] == ')')
                {
                    if (s[i - 1] == '(')
                    {
                        memo[i] = (i < 2 ? 0 : memo[i - 2]) + 2;
                    }
                    else if (i - memo[i - 1] - 1 >= 0 && s[i - memo[i - 1] - 1] == '(')
                    {
                        var len1 = 2 + memo[i - 1];
                        var len2 = (i - memo[i - 1]) < 2 ? 0 : memo[i - memo[i - 1] - 2];
                        memo[i] = len1 + len2;
                    }
                    maxLen = Math.Max(maxLen, memo[i]);
                }
            }
            return maxLen;
        }
    }
}

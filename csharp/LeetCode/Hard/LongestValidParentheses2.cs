namespace LeetCode.Hard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solution
    {
        public int LongestValidParentheses2(string s)
        {
            var stack = new Stack<int>();
            var maxLen = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else
                {
                    var peekChar = stack.Any() ? s[stack.Peek()] : ' ';
                    if (peekChar == '(')
                    {
                        stack.Pop();
                        var prePos = stack.Any() ? stack.Peek() : -1;
                        maxLen = Math.Max(maxLen, i - prePos);
                    }
                    else
                    {
                        stack.Push(i);
                    }
                }
            }
            return maxLen;
        }
    }
}

namespace LeetCode.Medium
{
    using System.Collections.Generic;
    using System.Text;

    public partial class Solution
    {
        public string DecodeString(string s)
        {
            var stack = new Stack<(int, StringBuilder)>();
            var sb = new StringBuilder();
            var number = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    number = number * 10 + (s[i] - '0');
                }
                else if (s[i] == '[')
                {
                    stack.Push((number, sb));
                    number = 0;
                    sb = new StringBuilder();
                }
                else if (s[i] == ']')
                {
                    var (count, prevSb) = stack.Pop();
                    while (count > 0)
                    {
                        prevSb.Append(sb);
                        count--;
                    }
                    sb = prevSb;
                }
                else
                {
                    sb.Append(s[i]);
                }
            }
            return sb.ToString();
        }
    }
}

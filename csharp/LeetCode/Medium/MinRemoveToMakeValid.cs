namespace LeetCode.Medium.MinRemoveToMakeValid
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Solution
    {
        public string MinRemoveToMakeValid(string s)
        {
            var stack = new Stack<int>();
            var sb = new StringBuilder(s);
            var i = 0;
            while (i < sb.Length)
            {
                if (sb[i] == ')')
                {
                    if (stack.Count == 0)
                    {
                        sb.Remove(i, 1);
                    }
                    else
                    {
                        stack.Pop();
                        i++;
                    }
                }
                else if (sb[i] == '(')
                {
                    stack.Push(i);
                    i++;
                }
                else
                {
                    i++;
                    // do nothing.
                }
            }
            while (stack.Any())
            {
                sb.Remove(stack.Pop(), 1);
            }
            return sb.ToString();
        }
    }
}

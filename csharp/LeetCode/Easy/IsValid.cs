namespace LeetCode.Easy
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solution
    {
        private readonly Dictionary<char, char> Parentheses = new Dictionary<char, char>
        {
            { '[' , ']' },
            { '(' , ')' },
            { '{' , '}' },
        };

        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                if (Parentheses.TryGetValue(c, out var value))
                {
                    stack.Push(value);
                }
                else if (!stack.Any())
                {
                    return false;
                }
                else if (stack.Pop() != c)
                {
                    return false;
                }
            }
            return !stack.Any();
        }
    }
}

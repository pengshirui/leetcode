namespace LeetCode.Medium.Calculate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public int Calculate(string s)
        {
            var stack = new Stack<int>();
            var digit = 0;
            var operation = '+';
            for (var i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];
                if (char.IsDigit(currentChar))
                {
                    digit = digit * 10 + currentChar - '0';
                }
                if (!char.IsDigit(currentChar) && !char.IsWhiteSpace(currentChar) || i == s.Length - 1)
                {
                    if (operation == '+')
                    {
                        stack.Push(digit);
                    }
                    else if (operation == '-')
                    {
                        stack.Push(-digit);
                    }
                    else if (operation == '*')
                    {
                        stack.Push(stack.Pop() * digit);
                    }
                    else if (operation == '/')
                    {
                        stack.Push(stack.Pop() / digit);
                    }
                    operation = currentChar;
                    digit = 0;
                }
            }

            return stack.Sum();
        }
    }
}

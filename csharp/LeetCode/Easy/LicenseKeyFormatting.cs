namespace LeetCode.Easy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class Solution
    {
        public string LicenseKeyFormatting(string s, int k)
        {
            var stack = new Stack<char>();
            var strB = new StringBuilder();
            int groupCounter = k;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                char c = s[i];
                if (c != '-')
                {
                    if (groupCounter > 0)
                    {
                        stack.Push(char.ToUpper(c));
                        groupCounter--;
                    }
                    else
                    {
                        stack.Push('-');
                        stack.Push(char.ToUpper(c));
                        groupCounter = k - 1;
                    }
                }
            }
            foreach (char c in stack)
            {
                strB.Append(c);
            }
            return strB.ToString();
        }
    }
}

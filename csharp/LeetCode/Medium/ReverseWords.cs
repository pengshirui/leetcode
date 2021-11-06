namespace LeetCode.Medium.ReverseWords
{
    using System;
    using System.Linq;

    public class Solution
    {
        public string ReverseWords(string s)
        {
            var words = s.Split(" ").Where(a => !string.IsNullOrEmpty(a)).Reverse();
            return string.Join(" ", words);
        }
    }
}

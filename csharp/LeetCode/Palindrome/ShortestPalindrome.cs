namespace LeetCode.Palindrome.ShortestPalindrome
{
    using System;
    using System.Text;

    public class Solution
    {
        public string ShortestPalindrome(string s)
        {
            var sb = new StringBuilder();
            var arr = s.ToCharArray();
            Array.Reverse(arr);
            var w = new string(arr);
            while (!s.StartsWith(w))
            {
                sb.Append(w[0]);
                w = w.Substring(1);
            }
            sb.Append(s);
            return sb.ToString();
        }
    }
}

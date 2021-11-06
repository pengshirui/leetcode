namespace LeetCode.Easy.IsPalindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            var l = 0;
            var r = s.Length - 1;

            while (l < r)
            {
                if (!char.IsLetterOrDigit(s[l]))
                {
                    l++;
                }
                else if (!char.IsLetterOrDigit(s[r]))
                {
                    r--;
                }
                else
                {
                    if (char.ToLower(s[l]) != char.ToLower(s[r]))
                    {
                        return false;
                    }
                    l++;
                    r--;
                }
            }
            return true;
        }

        public bool IsPalindrome(int n)
        {
            if (n < 0)
            {
                return false;
            }
            var x = n;
            var y = 0;
            while (x > 0)
            {
                var r = x % 10;
                y = y * 10 + r;
                x /= 10;
            }
            return n == y;
        }
    }
}

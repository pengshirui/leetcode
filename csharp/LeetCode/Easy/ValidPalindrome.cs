namespace LeetCode.Easy
{
    public partial class Solution
    {
        public bool ValidPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length <= 2)
            {
                return true;
            }

            var l = 0;
            var r = s.Length - 1;
            while (l < r)
            {
                if (s[l] == s[r])
                {
                    l++;
                    r--;
                }
                else
                {
                    return this.IsPalindrome(s, l + 1, r) || this.IsPalindrome(s, l, r - 1);
                }
            }
            return true;
        }

        bool IsPalindrome(string s, int l, int r)
        {
            while (l < r)
            {
                if (s[l] == s[r])
                {
                    l++;
                    r--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}

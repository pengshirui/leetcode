namespace LeetCode.Palindrome.CountSubstrings
{
    public class Solution
    {
        public int CountSubstrings(string s)
        {
            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                res += Count(s, i - 1, i) + Count(s, i, i);
            }

            return res;

        }

        int Count(string s, int l, int r)
        {
            var cnt = 0;

            while (l >= 0 && r < s.Length && s[l--] == s[r++])
            {
                cnt++;
            }

            return cnt;
        }
    }
}

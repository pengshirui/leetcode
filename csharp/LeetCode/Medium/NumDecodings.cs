namespace LeetCode.Medium
{
    public partial class Solution
    {
        public int NumDecodings(string s)
        {
            var memo = new int[s.Length];
            if (s[0] == '0')
                return 0;
            memo[s.Length - 1] = s[s.Length - 1] == '0' ? 0 : 1;

            for (var i = s.Length - 2; i >= 0; i--)
            {
                if (s[i] == '1' || s[i] == '2' && s[i + 1] - '0' <= 6)
                {
                    var memo2 = i + 2 < s.Length ? memo[i + 2] : 1;
                    memo[i] = memo[i + 1] + memo2;
                }
                else if (s[i] == '0')
                {
                    memo[i] = 0;
                }
                else
                {
                    memo[i] = memo[i + 1];
                }
            }
            return memo[0];
        }
    }
}

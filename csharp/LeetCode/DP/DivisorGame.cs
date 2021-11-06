namespace LeetCode.DP
{
    public class Solution
    {
        bool[] dp;
        public bool DivisorGame(int n)
        {
            dp = new bool[n + 1];
            for (var i = 2; i <= n; i++)
            {
                dp[i] = Check(i);
            }
            return dp[n];
        }

        bool Check(int i)
        {
            for (var j = 1; j < i; j++)
            {
                if (i % j == 0)
                {
                    if (!dp[i - j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

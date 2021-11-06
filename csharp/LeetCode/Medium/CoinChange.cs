namespace LeetCode.Medium
{
    using System;

    public partial class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            var memo = new int[amount + 1];
            Array.Fill(memo, amount + 1);
            memo[0] = 0;

            foreach (var coin in coins)
            {
                for (var i = coin; i <= amount; i++)
                {
                    memo[i] = Math.Min(memo[i], memo[i - coin] + 1);
                }
            }

            return memo[amount] == amount + 1 ? -1 : memo[amount];

        }
    }
}

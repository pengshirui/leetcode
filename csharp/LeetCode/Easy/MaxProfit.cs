namespace LeetCode.Easy
{
    using System;

    public partial class Solution
    {
        public int MaxProfit(params int[] prices)
        {
            var result = 0;
            if (prices == null || prices.Length < 2)
            {
                return result;
            }
            var low = prices[0];
            for (var i = 1; i < prices.Length; i++)
            {
                low = Math.Min(prices[i], low);
                result = Math.Max(prices[i] - low, result);
            }

            return result;
        }
    }
}

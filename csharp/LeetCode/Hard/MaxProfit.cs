namespace LeetCode.Hard.MaxProfit
{
    using System;

    public class Solution
    {
        public int MaxProfit(params int[] prices)
        {
            var c1 = prices[0];
            var p1 = 0;
            var balance = -c1;
            var profit = 0;
            foreach (var price in prices)
            {
                c1 = Math.Min(price, c1);
                p1 = Math.Max(p1, price - c1);
                balance = Math.Max(balance, p1 - price);
                profit = Math.Max(profit, balance + price);
            }
            return profit;
        }
    }
}

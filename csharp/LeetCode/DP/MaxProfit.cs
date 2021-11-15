namespace LeetCode.DP.MaxProfit
{
    using System;

    public class Solution
    {
        int INF = int.MaxValue / 2;
        public int MaxProfit(params int[] prices)
        {
            var n = prices.Length;
            var f = new int[3, 2];

            for (var i = 0; i <= n; i++)
            {
                f[0, 0] = f[0, 1] = 0;
                for (var j = 1; j < 3; j++)
                {
                    f[j, 0] = f[j, 1] = -INF;
                }
            }
            for (var i = 1; i <= n; i++)
            {
                var p = prices[i - 1];
                for (var j = 1; j < 3; j++)
                {
                    f[j, 0] = Math.Max(f[j, 0], f[j, 1] + p);
                    f[j, 1] = Math.Max(f[j - 1, 0] - p, f[j, 1]);
                }
            }

            var res = 0;
            for (var j = 0; j < 3; j++) res = Math.Max(res, f[j, 0]);
            return res;
        }
    }
}

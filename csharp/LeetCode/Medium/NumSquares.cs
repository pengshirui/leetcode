namespace LeetCode.Medium.NumSquares
{
    using System;

    public class Solution
    {
        public int NumSquares(int n)
        {
            var results = new int[n + 1];
            Array.Fill(results, n + 1);
            results[0] = 0;
            for (var i = 1; i * i <= n; i++)
            {
                var k = i * i;
                for (var j = k; j <= n; j++)
                {
                    results[j] = Math.Min(results[j - k] + 1, results[j]);
                }
            }
            return results[n];
        }
    }
}

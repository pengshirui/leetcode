namespace LeetCode.DP.MinDifficulty
{
    using System;

    public class Solution
    {
        int INF = int.MaxValue / 2;
        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            var n = jobDifficulty.Length;
            if (n < d) return -1;
            var f = new int[n + 1, d + 1];

            for (var i = 1; i <= n; i++)
                for (var j = 0; j < i && j <= d; j++) f[i, j] = INF;

            for (var i = 1; i <= n; i++)
            {
                for (var j = 1; j <= i && j <= d; j++)
                {
                    f[i, j] = int.MaxValue;
                    var job = jobDifficulty[i - 1];
                    for (var k = 1; i - k >= j - 1; k++)
                    {
                        job = Math.Max(job, jobDifficulty[i - k]);
                        f[i, j] = Math.Min(f[i, j], f[i - k, j - 1] + job);
                    }
                }
            }
            return f[n, d];
        }
    }
}

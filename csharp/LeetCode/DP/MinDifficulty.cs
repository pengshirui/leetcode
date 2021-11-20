namespace LeetCode.DP.MinDifficulty
{
    using System;

    public class Solution
    {
        int m, n;
        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            if (d > jobDifficulty.Length) return -1;
            m = jobDifficulty.Length;
            n = d;
            var f = new int[m + 1, n + 1];
            var mw = new int[m + 1];


            for (var i = 1; i <= m; i++)
            {
                var job = jobDifficulty[i - 1];
                for (var j = 1; j <= i; j++)
                {
                    mw[i] = job;
                    for (var k = i - 1; k > j; k--)
                    {
                        mw[k] = Math.Max(mw[k + 1], jobDifficulty[k - 1]);
                    }
                    f[i, j] = int.MaxValue;
                    for (var k = i; k >= j; k--)
                    {
                        f[i, j] = Math.Min(f[i, j], f[k - 1, j - 1] + mw[k]);
                    }
                }
            }
            return f[m, n];
        }
    }
}

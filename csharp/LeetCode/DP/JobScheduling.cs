namespace LeetCode.DP.JobScheduling
{
    using System;
    using System.Linq;

    public class Solution
    {
        int[,] f;
        public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
        {
            int m = startTime.Length;
            int n = endTime.Max();

            (int, int, int)[] lists = new (int, int, int)[m];
            for (var i = 0; i < m; i++)
            {
                lists[i] = (startTime[i], endTime[i], profit[i]);
            }

            Array.Sort(lists);

            f = new int[m + 1, n + 1];

            for (var i = 1; i <= m; i++)
            {
                var start = lists[i - 1].Item1;
                var end = lists[i - 1].Item2;
                var p = lists[i - 1].Item3;
                for (var j = 1; j <= n; j++)
                {
                    f[i, j] = Math.Max(f[i, j], f[i - 1, j]);
                    if (end <= j)
                    {
                        f[i, j] = Math.Max(f[i, j], p + f[i - 1, start]);
                    }
                }
            }

            return f[m, n];
        }
    }
}

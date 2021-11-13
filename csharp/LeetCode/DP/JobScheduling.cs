namespace LeetCode.DP.JobScheduling
{
    using System;
    using System.Linq;

    public class Solution
    {
        int m, n;
        int[] f;
        (int, int, int)[] jobs;
        public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
        {
            m = startTime.Length;
            n = endTime.Max();
            f = new int[n + 1];
            jobs = new (int, int, int)[m];
            for (var i = 0; i < m; i++)
            {
                jobs[i] = (startTime[i], endTime[i], profit[i]);
            }

            Array.Sort(jobs);

            for (var i = 1; i <= m; i++)
            {
                var (st, ed, pf) = jobs[i - 1];
                for (var j = n; j >= ed; j--)
                {
                    f[j] = Math.Max(f[j], f[st] + pf);
                }
            }
            return f[n];
        }
    }
}

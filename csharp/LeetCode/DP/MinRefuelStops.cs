namespace LeetCode.DP.MinRefuelStops
{
    using System;

    public class Solution
    {
        int n;
        int[] f;

        public int MinRefuelStops(int target, int startFuel, int[][] stations)
        {
            n = stations.Length;
            f = new int[n + 1];
            Array.Fill(f, startFuel);

            for (var i = 1; i <= n; i++)
            {
                for (var j = i; j >= 1; j--)
                {
                    if (f[j - 1] >= stations[i - 1][0])
                    {
                        f[j] = Math.Max(f[j], f[j - 1] + stations[i - 1][1]);
                    }
                }
            }

            for (var i = 0; i <= n; i++)
            {
                if (f[i] >= target) return i;
            }
            return -1;
        }
    }
}

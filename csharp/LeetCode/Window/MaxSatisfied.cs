namespace LeetCode.Window.MaxSatisfied
{
    using System;

    public class Solution
    {
        public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
        {
            var n = customers.Length;
            var ps = new int[n + 1];
            var ps2 = new int[n + 1];
            for (var i = 1; i <= n; i++)
            {
                var c = customers[i - 1];
                var p = 1 - grumpy[i - 1];
                ps[i] = ps[i - 1] + c;
                ps2[i] = ps2[i - 1] + c * p;
            }
            if (minutes >= n) return ps[n];
            var res = 0;
            for (var i = 0; i + minutes <= n; i++)
            {
                var p1 = ps2[i] - ps2[0];
                var p2 = ps[i + minutes] - ps[i];
                var p3 = ps2[n] - ps2[i + minutes];

                res = Math.Max(res, p1 + p2 + p3);
            }

            return res;
        }
    }
}

namespace LeetCode.Medium.Merge
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

            var res = new List<int[]>();
            var start = intervals[0][0];
            var end = intervals[0][1];
            for (var i = 0; i < intervals.Length; i++)
            {
                var a = intervals[i][0];
                var b = intervals[i][1];
                if (a <= end)
                {
                    end = Math.Max(end, b);
                }
                else
                {
                    res.Add(new int[] { start, end });
                    start = a;
                    end = b;
                }
            }

            res.Add(new int[] { start, end });
            return res.ToArray();
        }
    }
}

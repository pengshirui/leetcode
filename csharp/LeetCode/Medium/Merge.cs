namespace LeetCode.Medium
{
    using System;
    using System.Collections.Generic;

    public partial class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
            var ans = new List<int[]>();
            var start = intervals[0][0];
            var end = intervals[0][1];
            for (var i = 0; i < intervals.Length; i++)
            {
                var first = intervals[i][0];
                var second = intervals[i][1];
                if (first <= end)
                {
                    end = Math.Max(second, end);
                }
                else if (first > end)
                {
                    ans.Add(new int[] { start, end });
                    start = first;
                    end = second;
                }
            }
            ans.Add(new int[] { start, end });
            return ans.ToArray();
        }
    }
}

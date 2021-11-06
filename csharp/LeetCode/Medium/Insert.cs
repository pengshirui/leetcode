namespace LeetCode.Medium.Insert
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var result = new List<int[]>();
            int i = 0;
            int start = newInterval[0];
            int end = newInterval[1];

            while (i < intervals.Length && intervals[i][1] < start)
            {
                result.Add(intervals[i++]);
            }

            while (i < intervals.Length && intervals[i][0] <= end)
            {
                start = Math.Min(start, intervals[i][0]);
                end = Math.Max(end, intervals[i][1]);
                i++;
            }
            result.Add(new int[2] { start, end });

            while (i < intervals.Length)
            {
                result.Add(intervals[i++]);
            }

            return result.ToArray();
        }
    }
}

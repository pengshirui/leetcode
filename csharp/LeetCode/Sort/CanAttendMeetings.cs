namespace LeetCode.Sort.CanAttendMeetings
{
    using System;

    public class Solution
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
            for (var i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] < intervals[i - 1][1]) return false;
            }
            return true;
        }
    }
}

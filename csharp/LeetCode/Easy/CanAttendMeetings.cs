namespace LeetCode.Easy
{
    using System;

    public partial class Solution
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            var starts = new int[intervals.Length];
            var ends = new int[intervals.Length];
            for (var i = 0; i < intervals.Length; i++)
            {
                starts[i] = intervals[i][0];
                ends[i] = intervals[i][1];
            }
            Array.Sort(starts);
            Array.Sort(ends);

            for (var i = 1; i < starts.Length; i++)
            {
                if (starts[i] < ends[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

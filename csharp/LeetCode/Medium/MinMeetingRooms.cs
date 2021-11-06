namespace LeetCode.Medium
{
    using System;

    public partial class Solution
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            var starts = new int[intervals.Length];
            var ends = new int[intervals.Length];
            for (var index = 0; index < intervals.Length; index++)
            {
                starts[index] = intervals[index][0];
                ends[index] = intervals[index][1];
            }
            Array.Sort(starts);
            Array.Sort(ends);

            var i = 0;
            var j = 0;
            var ans = 0;
            while (i < starts.Length && j < ends.Length)
            {
                if (starts[i] < ends[j])
                {
                    i++;
                    ans++;
                }
                else
                {
                    i++;
                    j++;
                }
            }
            return ans;
        }
    }
}

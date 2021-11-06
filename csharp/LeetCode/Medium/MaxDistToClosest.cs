namespace LeetCode.Medium.MaxDistToClosest
{
    using System;

    public class Solution
    {
        public int MaxDistToClosest(params int[] seats)
        {
            var maxDis = 0;
            var l = -1;
            for (var i = 0; i < seats.Length; i++)
            {
                while (i < seats.Length && seats[i] != 1)
                {
                    i++;
                }
                maxDis = Math.Max(maxDis, (i - l) / 2);
                if (l == -1)
                {
                    maxDis = Math.Max(maxDis, i);
                }
                if (i == seats.Length)
                {
                    maxDis = Math.Max(seats.Length - l - 1, maxDis);
                }
                l = i;
            }

            return maxDis;
        }
    }
}

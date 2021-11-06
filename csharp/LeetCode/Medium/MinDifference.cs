namespace LeetCode.Medium.MinDifference
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        public int MinDifference(params int[] nums)
        {
            if (nums.Length < 5) return 0;
            var maxs = new int[4];
            Array.Fill(maxs, int.MinValue);
            var mins = new int[4];
            Array.Fill(mins, int.MaxValue);
            foreach (var n in nums)
            {
                Add(maxs, mins, n);
            }
            var min = int.MaxValue;
            for (int i = 0, j = 3; i < 4 && j >= 0; i++, j--)
            {
                min = Math.Min(min, (maxs[i] - mins[j]));
            }

            return min;
        }

        void Add(IList<int> max, IList<int> min, int n)
        {
            if (n > max[0])
            {
                max[3] = max[2];
                max[2] = max[1];
                max[1] = max[0];
                max[0] = n;
            }
            else if (n > max[1])
            {
                max[3] = max[2];
                max[2] = max[1];
                max[1] = n;
            }
            else if (n > max[2])
            {
                max[3] = max[2];
                max[2] = n;
            }
            else if (n > max[3])
            {
                max[3] = n;
            }

            if (n < min[0])
            {
                min[3] = min[2];
                min[2] = min[1];
                min[1] = min[0];
                min[0] = n;
            }
            else if (n < min[1])
            {
                min[3] = min[2];
                min[2] = min[1];
                min[1] = n;
            }
            else if (n < min[2])
            {
                min[3] = min[2];
                min[2] = n;
            }
            else if (n < min[3])
            {
                min[3] = n;
            }
        }
    }
}

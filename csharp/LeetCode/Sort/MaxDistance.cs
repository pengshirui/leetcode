namespace LeetCode.Sort.MaxDistance
{
    using System;

    public class Solution
    {
        public int MaxDistance(int[] position, int m)
        {
            Array.Sort(position);

            var l = 1;
            var r = position[position.Length - 1] - position[0];
            while (l < r)
            {
                var mi = l + r + 1 >> 1;
                if (Check(position, mi, m - 1))
                {
                    l = mi;
                }
                else
                {
                    r = mi - 1;
                }
            }
            return l;
        }

        bool Check(int[] nums, int d, int m)
        {
            var i = 0;
            while (i < nums.Length && m-- > 0)
            {
                int j = i;
                while (j < nums.Length && nums[j] - nums[i] < d) j++;
                if (j >= nums.Length) return false;
                i = j;
            }
            return true;
        }
    }
}

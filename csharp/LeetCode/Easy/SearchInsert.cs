namespace LeetCode.Easy.SearchInsert
{
    using System;

    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            var i = Array.BinarySearch(nums, target);
            if (i >= 0)
            {
                return i;
            }
            return ~i;
        }

        public int SearchInsert2(int[] nums, int target)
        {
            var l = 0;
            var r = nums.Length;
            while (l < r)
            {
                var m = (l + r) / 2;
                var middle = nums[m];
                if (middle == target)
                {
                    return m;
                }
                else if (middle < target)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }
            return l;
        }
    }
}

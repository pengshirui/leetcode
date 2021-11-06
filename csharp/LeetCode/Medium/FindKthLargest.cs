namespace LeetCode.Medium
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums, (a, b) => b - a);

            return nums[k - 1];
        }
    }
}

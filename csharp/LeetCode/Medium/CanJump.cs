namespace LeetCode.Medium
{
    using System;

    public partial class Solution
    {
        public bool CanJump(params int[] nums)
        {
            var max = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (max < i)
                {
                    return false;
                }
                max = Math.Max(max, nums[i] + i);
            }
            return true;
        }
    }
}

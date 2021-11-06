namespace LeetCode.Easy
{
    using System;

    public partial class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            var curSub = nums[0];
            var maxSub = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                curSub = Math.Max(nums[i], nums[i] + curSub);
                maxSub = Math.Max(curSub, maxSub);
            }
            return maxSub;
        }
    }
}

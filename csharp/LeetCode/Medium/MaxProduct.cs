namespace LeetCode.Medium.MaxProduct
{
    using System;

    public class Solution
    {
        public int MaxProduct(params int[] nums)
        {
            var max = nums[0];
            var min = nums[0];
            var result = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                var m = max;
                max = Math.Max(nums[i] * min, nums[i] * m);
                max = Math.Max(max, nums[i]);
                min = Math.Min(nums[i] * min, nums[i] * m);
                min = Math.Min(min, nums[i]);

                result = Math.Max(result, max);
            }
            return result;
        }
    }
}

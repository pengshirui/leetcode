namespace LeetCode.Easy.FindLengthOfLCIS
{
    using System;

    public class Solution
    {
        public int FindLengthOfLCIS(params int[] nums)
        {
            var res = 1;
            var prev = nums[0];
            var len = 1;
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] > prev)
                {
                    len++;
                }
                else
                {
                    res = Math.Max(res, len);
                    len = 1;
                }
                prev = nums[i];
            }
            return Math.Max(res, len);
        }
    }
}

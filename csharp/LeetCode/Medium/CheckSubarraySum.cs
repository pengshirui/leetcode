namespace LeetCode.Medium
{
    using System.Collections.Generic;

    public partial class Solution
    {
        public bool CheckSubarraySum(int[] nums, int k)
        {
            var preSum = 0;
            var kv = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                preSum += nums[i];
                if (k != 0)
                {
                    preSum %= k;
                }
                if (preSum == 0 && i > 0)
                {
                    return true;
                }
                if (kv.TryGetValue(preSum, out var prev))
                {
                    if (i - prev > 1)
                        return true;
                }
                else
                {
                    kv[preSum] = i;
                }
            }
            return false;
        }
    }
}

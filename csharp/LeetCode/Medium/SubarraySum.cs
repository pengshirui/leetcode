namespace LeetCode.Medium.SubarraySum
{
    using System.Collections.Generic;

    public class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            var count = 0;
            var sum = 0;
            var kv = new Dictionary<int, int>() { { 0, 1 } };

            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                var diff = sum - k;
                if (kv.ContainsKey(diff))
                {
                    count += kv[diff];
                }
                kv.TryAdd(sum, 0);
                kv[sum]++;
            }
            return count;
        }
    }
}

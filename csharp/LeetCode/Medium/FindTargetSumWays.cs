namespace LeetCode.Medium
{
    using System.Collections.Generic;

    public partial class Solution
    {
        public int FindTargetSumWays(int[] nums, int target)
        {
            var memo = new Dictionary<int, Dictionary<int, int>>();
            memo[0] = new Dictionary<int, int>
            {
                { nums[0], 1 },
            };
            var count = memo[0].GetValueOrDefault(-nums[0], 0) + 1;
            memo[0][-nums[0]] = count;

            for (var i = 1; i < nums.Length; i++)
            {
                var targetSums = memo[i - 1];
                memo[i] = new Dictionary<int, int>();
                foreach (var ts in targetSums)
                {
                    var newKey = ts.Key + nums[i];
                    var newCount = memo[i].GetValueOrDefault(newKey, 0) + ts.Value;
                    memo[i][newKey] = newCount;
                    newKey = ts.Key - nums[i];
                    newCount = memo[i].GetValueOrDefault(newKey, 0) + ts.Value;
                    memo[i][newKey] = newCount;
                }
            }

            return memo[nums.Length - 1].GetValueOrDefault(target, 0);
        }
    }
}


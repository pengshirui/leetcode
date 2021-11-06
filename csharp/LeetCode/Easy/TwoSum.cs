/// <summary>
/// https://leetcode.com/problems/two-sum
/// </summary>

using System.Collections.Generic;

namespace LeetCode.Easy
{
    public partial class Solution
    {
        // return index of two numbers
        public int[] TwoSum(int[] nums, int target)
        {
            // Dictionary<Value in difference, CurrentIndex>
            // [1, 4] target = 5
            // <4, 0>
            var dictionary = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (dictionary.TryGetValue(nums[i], out var value))
                {
                    return new int[] { value, i };
                }

                dictionary[target - nums[i]] = i;
            }

            return new int[0];
        }
    }
}

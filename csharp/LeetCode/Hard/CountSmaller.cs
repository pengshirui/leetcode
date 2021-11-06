namespace LeetCode.Hard.CountSmaller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LeetCode.DataStructures;

    public class Solution
    {
        public IList<int> CountSmaller(params int[] nums)
        {

            var offset = nums.Max(a => Math.Abs(a));
            var size = offset * 2 + 1;
            var fenwickTree = new FenwickTree(size, offset);

            var result = new int[nums.Length];
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                result[i] = fenwickTree.Query(nums[i]);
                fenwickTree.Update(nums[i], 1);
            }

            return result;
        }
    }
}

namespace LeetCode.Medium
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solution
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Array.Sort(nums);
            var result = new List<IList<int>>();
            PermuteUniqueInternal(nums, new Stack<int>(), result);
            return result;
        }

        void PermuteUniqueInternal(int[] nums, Stack<int> stack, List<IList<int>> result)
        {
            if (!nums.Any())
            {
                result.Add(stack.ToList());
            }

            for (var i = 0; i < nums.Length; i++)
            {
                var cur = nums[i];
                if (i > 0 && nums[i - 1] == cur)
                {
                    continue;
                }
                var newNums = nums.Where((_, k) => k != i).ToArray();
                stack.Push(nums[i]);
                PermuteUniqueInternal(newNums, stack, result);
                stack.Pop();
            }
        }
    }
}

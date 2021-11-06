using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            PermuteInternal(nums, new Stack<int>(), result);
            return result;
        }

        public void PermuteInternal(int[] nums, Stack<int> stack, IList<IList<int>> result)
        {
            if (!nums.Any())
            {
                result.Add(stack.ToList());
            }

            for (var i = 0; i < nums.Length; i++)
            {
                var newNums = nums.Where((_, k) => k != i).ToArray();
                stack.Push(nums[i]);
                PermuteInternal(newNums, stack, result);
                stack.Pop();
            }
        }
    }
}

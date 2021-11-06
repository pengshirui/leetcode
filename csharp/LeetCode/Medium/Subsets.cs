namespace LeetCode.Medium
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            SubsetsInternal(nums, 0, new Stack<int>(), result);
            return result;
        }

        void SubsetsInternal(int[] nums, int start, Stack<int> stack, List<IList<int>> result)
        {
            if (start == nums.Length)
            {
                result.Add(stack.ToList());
                return;
            }
            stack.Push(nums[start]);
            SubsetsInternal(nums, start + 1, stack, result);
            stack.Pop();
            SubsetsInternal(nums, start + 1, stack, result);
        }
    }
}

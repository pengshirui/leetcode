namespace LeetCode.Medium.FourSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            if (nums == null || nums.Length < 4)
            {
                return result.ToList();
            }
            Array.Sort(nums);
            for (var i = 0; i < nums.Length; i++)
            {
                if (i - 1 >= 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                var sums = ThreeSum(nums, i + 1, target - nums[i]);
                foreach (var sum in sums)
                {
                    var s = new List<int> { nums[i] };
                    s.AddRange(sum);
                    result.Add(s);
                }
            }
            return result.ToList();
        }

        IList<IList<int>> ThreeSum(int[] nums, int start, int target)
        {
            var result = new List<IList<int>>();
            for (var i = start; i < nums.Length; i++)
            {
                if (i - 1 >= start && nums[i] == nums[i - 1])
                {
                    continue;
                }
                var sums = TwoSum(nums, i + 1, target - nums[i]);
                foreach (var sum in sums)
                {
                    var s = new List<int> { nums[i] };
                    s.AddRange(sum);
                    result.Add(s);
                }
            }
            return result;
        }

        IList<IList<int>> TwoSum(int[] nums, int start, int target)
        {
            var l = start;
            var r = nums.Length - 1;
            var result = new List<IList<int>>();
            while (l < r)
            {
                if (l - 1 >= start && nums[l - 1] == nums[l])
                {
                    l++;
                }
                else if (nums[l] + nums[r] == target)
                {
                    var pair = new List<int> { nums[l], nums[r] };
                    result.Add(pair);
                    l++;
                    r--;
                }
                else if (nums[l] + nums[r] > target)
                {
                    r--;
                }
                else if (nums[l] + nums[r] < target)
                {
                    l++;
                }
                else
                {
                    return result;
                }
            }
            return result;
        }
    }
}

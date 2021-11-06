namespace LeetCode.Medium.ThreeSum
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var ans = new List<IList<int>>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                var target = -nums[i];
                var l = i + 1;
                var r = nums.Length - 1;
                while (l < r)
                {
                    var twoSum = nums[l] + nums[r];
                    if (twoSum > target)
                    {
                        r--;
                    }
                    else if (twoSum < target)
                    {
                        l++;
                    }
                    else
                    {
                        ans.Add(new int[] { -target, nums[l], nums[r] });
                        do
                        {
                            l++;
                        }
                        while (l < r && nums[l] == nums[l - 1]);
                        do
                        {
                            r--;
                        }
                        while (l < r && nums[r] == nums[r + 1]);
                    }
                }


            }
            return ans;
        }
    }
}

namespace LeetCode.Medium
{
    using System;

    public partial class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            var ans = int.MaxValue;
            for (var i = 0; i < nums.Length; i++)
            {
                var l = i + 1;
                var r = nums.Length - 1;
                while (l < r)
                {
                    var diff = nums[i] + nums[l] + nums[r] - target;
                    if (Math.Abs(diff) < Math.Abs(ans))
                    {
                        ans = diff;
                    }

                    if (diff > 0)
                    {
                        // to big;
                        r--;
                    }
                    else if (diff < 0)
                    {
                        l++;
                    }
                    else
                    {
                        return target;
                    }
                }
            }
            return target + ans;
        }
    }
}

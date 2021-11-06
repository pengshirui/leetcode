namespace LeetCode.Hard.FirstMissingPositive
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        public int FirstMissingPositive(params int[] nums)
        {
            var l = 0;
            var r = nums.Length; // start from nums.Length;
            while (l != r)
            {
                var val = nums[l];
                if (val == l + 1)
                {
                    l++;
                }
                else if (val > r || val <= 0 || nums[val - 1] == val)
                {
                    r--;
                    var t = nums[l];
                    nums[l] = nums[r];
                    nums[r] = t;
                }
                else
                {
                    var t = nums[l];
                    nums[l] = nums[val - 1];
                    nums[val - 1] = t;
                }

            }
            return l + 1;
        }
    }
}

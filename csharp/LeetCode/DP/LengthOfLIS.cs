namespace LeetCode.DP.LengthOfLIS
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        public int LengthOfLIS(params int[] nums)
        {
            var n = nums.Length;
            var q = new int[n + 1];
            q[0] = (int)-2e4;
            var res = 0;
            for (var i = 0; i < n; i++)
            {
                var l = 0;
                var r = res;
                while (l < r)
                {
                    var m = l + r + 1 >> 1;
                    if (q[m] < nums[i])
                    {
                        l = m;
                    }
                    else
                    {
                        r = m - 1;
                    }
                        
                }
                res = Math.Max(res, l + 1);
                q[l + 1] = nums[i];
            }
            return res;
        }
    }
}

namespace LeetCode.Medium.MaxArea
{
    using System;

    public class Solution
    {
        public int MaxArea(int[] height)
        {

            if (height.Length < 2)
            {
                return 0;
            }

            var l = 0;
            var r = height.Length - 1;
            var ans = 0;
            while (l < r)
            {
                var area = Math.Min(height[l], height[r]) * (r - l);
                ans = Math.Max(area, ans);
                if (height[l] <= height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return ans;
        }
    }
}

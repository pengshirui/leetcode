namespace LeetCode.Hard.MaxSlidingWindow
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        int[] win;
        List<int> res = new List<int>();
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            win = new int[nums.Length];
            var hh = 0;
            var tt = -1;
            for (var i = 0; i < nums.Length; i++)
            {
                var n = nums[i];
                if (hh <= tt && i - win[hh] >= k)
                {
                    hh++;
                }
                while (hh <= tt && nums[win[tt]] < n)
                {
                    tt--;
                }
                win[++tt] = i;
                if (i >= k - 1)
                {
                    res.Add(nums[win[hh]]);
                }
            }
            return res.ToArray();
        }
    }
}

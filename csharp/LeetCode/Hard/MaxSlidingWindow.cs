namespace LeetCode.Hard.MaxSlidingWindow
{
    public class Solution
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var win = new int[nums.Length];
            var res = new int[nums.Length - k + 1];
            var hh = 0;
            var tt = -1;
            var j = 0;
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
                    res[j++] = nums[win[hh]];
                }
            }
            return res;
        }
    }
}

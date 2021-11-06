namespace LeetCode.Medium
{
    public partial class Solution
    {
        public int Search(int[] nums, int target)
        {
            var l = 0;
            var r = nums.Length;
            while (l < r)
            {
                var m = (l + r) / 2;

                var mid = nums[m];
                // target and middle are on the different side of nums0
                if ((nums[m] < nums[0]) != (target < nums[0]))
                {
                    mid = target < nums[0] ? int.MinValue : int.MaxValue;
                }

                if (mid < target)
                    l = m + 1;
                else if (mid > target)
                    r = m;
                else
                    return m;
            }
            return -1;
        }
    }
}

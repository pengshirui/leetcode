namespace LeetCode.Medium
{
    public partial class Solution
    {
        public int FindPeakElement(int[] nums)
        {
            var l = 0;
            var r = nums.Length - 1;

            while (l < r)
            {
                var m = (l + r) / 2;
                if (nums[m] > nums[m + 1])
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }

            return l;
        }
    }
}

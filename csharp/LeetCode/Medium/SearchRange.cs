namespace LeetCode.Medium.SearchRange
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums == null || nums.Length < 1)
            {
                return new int[] { -1, -1 };
            }

            var l = 0;
            var r = nums.Length - 1;
            while (l < r)
            {
                var m = (l + r) / 2;
                if (nums[m] < target)
                {
                    l = m + 1;
                }
                else if (nums[m] >= target)
                {
                    r = m;
                }
            }
            if (nums[l] != target)
            {
                return new int[] { -1, -1 };
            }

            var result = new int[2] { l, r };
            r = nums.Length - 1;
            while (l < r)
            {
                var m = (l + r) / 2 + 1;
                if (nums[m] > target)
                {
                    r = m - 1;
                }
                else
                {
                    l = m;
                }
            }
            result[1] = r;

            return result;
        }
    }
}

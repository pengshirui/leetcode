namespace LeetCode.Easy
{
    using System.Collections.Generic;

    public partial class Solution
    {
        public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            var ans = new List<string>();
            var i = 0;
            while (i < nums.Length && nums[i] <= upper)
            {
                if (lower + 1 == nums[i])
                {
                    ans.Add($"{lower}");
                    lower = nums[i] + 1;
                }
                else if (lower < nums[i])
                {
                    ans.Add($"{lower}->{nums[i] - 1}");
                    lower = nums[i] + 1;
                }
                else
                {
                    lower = nums[i] + 1;
                    i++;
                }
            }
            if (lower < upper)
            {
                ans.Add($"{lower}->{upper}");
            }
            else if (lower == upper)
            {
                ans.Add($"{lower}");
            }
            return ans;
        }
    }
}

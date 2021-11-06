namespace LeetCode.Medium.ContainsNearbyAlmostDuplicate
{
    using System.Collections.Generic;
    using System.Linq;
    public class Solution
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            var l = 0;
            var r = 0;
            var set = new SortedSet<long>();
            while (r < nums.Length)
            {
                if (set.GetViewBetween((long)nums[r] - t, (long)nums[r] + t).Any()) return true;
                set.Add(nums[r++]);
                if (set.Count > k)
                {
                    set.Remove(nums[l++]);
                }
            }
            return false;
        }
    }
}

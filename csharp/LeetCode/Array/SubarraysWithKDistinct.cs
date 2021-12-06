namespace LeetCode.Array.SubarraysWithKDistinct
{
    using System.Collections.Generic;

    public class Solution
    {
        public int SubarraysWithKDistinct(int[] nums, int k)
        {
            return GetMostK(nums, k) - GetMostK(nums, k - 1);
        }

        int GetMostK(int[] nums, int k)
        {
            if (k == 0) return 0;
            var kv = new Dictionary<int, int>();
            var l = 0;
            var cnt = 0;
            for (var r = 0; r < nums.Length; r++)
            {
                kv.TryAdd(nums[r], 0);
                kv[nums[r]]++;
                while (kv.Count > k)
                {
                    kv[nums[l]]--;
                    if (kv[nums[l]] == 0) kv.Remove(nums[l]);
                    l++;
                }
                cnt += r - l + 1;
            }

            return cnt;
        }
    }
}

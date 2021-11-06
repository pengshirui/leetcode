namespace LeetCode.Medium
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var kv = new Dictionary<int, int>();
            foreach (var n in nums)
            {
                kv.TryAdd(n, 0);
                kv[n]++;
            }
            var result = new List<int>();
            foreach (var item in kv.OrderByDescending(i => i.Value))
            {
                result.Add(item.Key);
            }
            return result.Take(k).ToArray();
        }
    }
}

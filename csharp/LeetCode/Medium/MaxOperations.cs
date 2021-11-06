namespace LeetCode.Medium.MaxOperations
{
    using System.Collections.Generic;

    public class Solution
    {
        public int MaxOperations(int[] nums, int k)
        {
            var res = 0;
            var kv = new Dictionary<int, int>();
            foreach (var n in nums)
            {
                var diff = k - n;
                if (kv.ContainsKey(diff))
                {
                    if (kv[diff] > 0)
                    {
                        kv[diff]--;
                        res++;
                        continue;
                    }
                }
                kv.TryAdd(n, 0);
                kv[n]++;
            }
            return res;
        }
    }
}

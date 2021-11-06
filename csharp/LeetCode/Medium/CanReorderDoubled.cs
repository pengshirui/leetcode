namespace LeetCode.Medium.CanReorderDoubled
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public bool CanReorderDoubled(params int[] arr)
        {
            if (arr == null || arr.Length % 2 != 0) return false;
            var kv = new Dictionary<int, int>();
            foreach (var n in arr)
            {
                kv.TryAdd(n, 0);
                kv[n]++;
            }

            var keys = kv.Keys.OrderBy(k => Math.Abs(k));
            foreach (var k in keys)
            {
                var twok = k + k;
                var v = kv[k];
                if (v == 0) continue;
                if (kv.ContainsKey(twok))
                {
                    kv[twok] -= v;
                    if (kv[twok] < 0)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}

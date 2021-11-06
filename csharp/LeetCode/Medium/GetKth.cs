namespace LeetCode.Medium.GetKth
{
    using System.Linq;
    using System.Collections.Generic;

    public class Solution
    {
        private readonly Dictionary<int, int> KV = new Dictionary<int, int>()
        {
            { 1, 1 }
        };
        public int GetKth(int lo, int hi, int k)
        {
            var pairs = new Dictionary<int, int>();
            if (k >= hi - lo + 1)
            {
                return -1;
            }
            for (var i = lo; i <= hi; i++)
            {
                pairs[i] = GetPower(i);
            }

            var results = pairs.OrderBy(pair => pair.Value).Select(pair => pair.Key).ToList();
            return results[k - 1];

        }

        private int GetPower(int k)
        {
            if (KV.TryGetValue(k, out var value))
            {
                return value;
            }
            var r = k % 2 == 0 ? GetPower(k / 2) + 1 : GetPower(3 * k + 1) + 1;
            KV[k] = r;
            return r;
        }
    }
}

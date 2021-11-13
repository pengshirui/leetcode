namespace LeetCode.Medium.RestoreArray
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        Dictionary<int, List<int>> kv = new Dictionary<int, List<int>>();
        public int[] RestoreArray(int[][] adjacentPairs)
        {
            foreach (var pair in adjacentPairs)
            {
                kv.TryAdd(pair[0], new List<int>());
                kv[pair[0]].Add(pair[1]);
                kv.TryAdd(pair[1], new List<int>());
                kv[pair[1]].Add(pair[0]);
            }

            var res = new int[kv.Count];
            var start = kv.First(k => k.Value.Count == 1).Key;
            var last = start;
            for (var i = 0; i < res.Length; i++)
            {
                var t = start;
                res[i] = start;
                start = kv[start].FirstOrDefault(r => r != last);
                last = t;
            }
            return res;
        }
    }
}

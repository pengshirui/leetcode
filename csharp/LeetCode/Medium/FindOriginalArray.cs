namespace LeetCode.Medium.FindOriginalArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public int[] FindOriginalArray(params int[] changed)
        {
            if (changed.Length % 2 != 0) return new int[0];
            Array.Sort(changed);
            var kv = new Dictionary<int, Queue<int>>();
            for (var i = 0; i < changed.Length; i++)
            {
                kv.TryAdd(changed[i], new Queue<int>());
                kv[changed[i]].Enqueue(i);
            }
            var result = new List<int>();

            for (var i = 0; i < changed.Length; i++)
            {
                var q1 = kv[changed[i]];
                if (!q1.Any()) continue;
                q1.Dequeue();
                if (!kv.ContainsKey(2 * changed[i])) return new int[0];
                var q2 = kv[2 * changed[i]];
                if (!q2.Any()) return new int[0];
                q2.Dequeue();
                result.Add(changed[i]);

            }
            return result.ToArray();
        }
    }
}

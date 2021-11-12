namespace LeetCode.DFS.MinTransfers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Solution
    {
        int INF = int.MaxValue;
        Dictionary<int, long> bal = new Dictionary<int, long>();
        List<long> debt;

        public int MinTransfers(int[][] transactions)
        {
            foreach (var t in transactions)
            {
                bal.TryAdd(t[0], 0);
                bal.TryAdd(t[1], 0);
                bal[t[0]] -= t[2];
                bal[t[1]] += t[2];
            }

            debt = bal.Values.Where(k => k != 0).ToList();
            return DFS(0);
        }

        int DFS(int start)
        {
            while (start < debt.Count && debt[start] == 0) start++;
            if (start == debt.Count) return 0;

            var r = INF;
            for (var i = start + 1; i < debt.Count; i++)
            {
                if (debt[start] * debt[i] < 0)
                {
                    debt[i] += debt[start];
                    r = Math.Min(r, 1 + DFS(start + 1));
                    debt[i] -= debt[start];
                }
            }
            return r;
        }
    }
}

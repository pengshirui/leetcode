namespace LeetCode.ShortestPath.CurrencyConvert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        int INF = int.MaxValue / 2;
        Queue<int> q = new Queue<int>();
        HashSet<int> hs = new HashSet<int>();
        List<(int, double)>[] next;
        double[] dist;
        int[] cnt;

        public double CurrencyConvert(int n, (int, int, double, double)[] nums, int x, int y, double count)
        {
            next = new List<(int, double)>[n];
            dist = new double[n];
            cnt = new int[n];
            Array.Fill(dist, -INF);
            dist[x] = 1;
            foreach (var (u, v, b, s) in nums)
            {
                if (next[u] == null) next[u] = new List<(int, double)>();
                next[u].Add((v, 1 / b));
                if (next[v] == null) next[v] = new List<(int, double)>();
                next[v].Add((u, s));
            }

            return SPFA(n, x, y, count);
        }

        double SPFA(int n, int x, int y, double count)
        {
            q.Enqueue(x);
            hs.Add(x);

            while (q.Any())
            {
                var u = q.Dequeue();
                hs.Remove(u);
                if (next[u] == null) continue;
                foreach (var (v, w) in next[u])
                {
                    if (dist[u] * w > dist[v])
                    {
                        cnt[v] = cnt[u] + 1;
                        if (cnt[v] >= n) return -1;
                        dist[v] = dist[u] * w;
                        if (hs.Contains(v)) continue;
                        q.Enqueue(v);
                        hs.Add(v);
                    }
                }
            }

            if (dist[y] <= -INF) return -1;
            return count * dist[y];
        }
    }
}

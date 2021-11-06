namespace LeetCode.ShortestPath.NetworkDelayTime
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        int INF = int.MaxValue / 2;
        int[] Dist;
        IList<IList<(int, int)>> Next = new List<IList<(int, int)>>();
        HashSet<int> St = new HashSet<int>();

        public int NetworkDelayTime2(int[][] times, int n, int k)
        {
            Dist = new int[n + 1];
            Array.Fill(Dist, INF);
            Dist[0] = 0;
            Dist[k] = 0;

            for (var i = 0; i <= n; i++)
            {
                if (i != 0) St.Add(i);
                Next.Add(new List<(int, int)>());
            }

            foreach (var time in times)
            {
                var u = time[0];
                var v = time[1];
                var w = time[2];
                Next[u].Add((v, w));
            }
            Dij(n);
            return St.Any() ? -1 : Dist.Max();
        }

        void Dij(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                var u = GetMinIndex();
                foreach (var (v, w) in Next[u])
                {
                    Dist[v] = Math.Min(Dist[v], Dist[u] + w);
                }
            }
        }

        int GetMinIndex()
        {
            var res = -1;
            var min = INF;
            foreach (var i in St)
            {
                if (Dist[i] < min)
                {
                    min = Dist[i];
                    res = i;
                }
            }
            St.Remove(res);
            return res;
        }

        public int NetworkDelayTime(int[][] times, int n, int k)
        {
            Dist = new int[n + 1];
            Array.Fill(Dist, INF);
            Dist[0] = 0;
            Dist[k] = 0;

            for (var i = 0; i <= n; i++)
            {
                Next.Add(new List<(int, int)>());
            }

            foreach (var time in times)
            {
                var u = time[0];
                var v = time[1];
                var w = time[2];
                Next[u].Add((v, w));
            }
            SPFA(k);
            return Dist.Max() >= INF ? -1 : Dist.Max();
        }
        void SPFA(int k)
        {
            var q = new Queue<int>();
            q.Enqueue(k);
            St.Add(k);
            while (q.Any())
            {
                var u = q.Dequeue();
                St.Remove(u);
                foreach (var (v, w) in Next[u])
                {
                    if (Dist[v] > Dist[u] + w)
                    {
                        Dist[v] = Dist[u] + w;
                        if (!St.Contains(v))
                        {
                            q.Enqueue(v);
                            St.Add(v);
                        }
                    }
                }

            }
        }
    }
}

namespace LeetCode.MinimumSpanningTree.MinimumCost
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        int INF = int.MaxValue;
        int[] Dist;
        HashSet<int> St;
        Dictionary<int, int>[] Next;
        int[] P;

        public int MinimumCost(int n, int[][] connections)
        {
            return Kruskal(n, connections);
        }

        int Prim(int n, int[][] connections)
        {
            Dist = new int[n + 1];
            St = new HashSet<int>();
            Next = new Dictionary<int, int>[n + 1];
            Array.Fill(Dist, INF);
            for (var i = 1; i <= n; i++)
            {
                St.Add(i);
                Next[i] = new Dictionary<int, int>();
            }

            foreach (var c in connections)
            {
                var u = c[0];
                var v = c[1];
                var w = c[2];
                var m = Next[u].GetValueOrDefault(v, INF);
                Next[u][v] = Next[v][u] = Math.Min(m, w);
            }

            var res = 0;
            // loop n times
            for (var i = 0; i < n; i++)
            {
                var t = -1;
                foreach (var j in St)
                {
                    if (t == -1 || Dist[t] > Dist[j])
                        t = j;
                }
                if (i != 0 && Dist[t] == INF)
                    return -1;
                if (i != 0) res += Dist[t];

                foreach (var (k, v) in Next[t])
                {
                    Dist[k] = Math.Min(Dist[k], v);
                }
                St.Remove(t);
            }

            return res;
        }

        int Kruskal(int n, int[][] connections)
        {
            P = new int[n + 1];
            for (var i = 1; i <= n; i++)
            {
                P[i] = i;
            }

            Array.Sort(connections, ((x, y) => x[2].CompareTo(y[2])));

            var res = 0;
            var cnt = 0;
            foreach (var c in connections)
            {
                var u = c[0];
                var v = c[1];
                var w = c[2];
                var x = Find(u);
                var y = Find(v);
                if (x != y)
                {
                    P[x] = y;
                    res += w;
                    cnt++;
                }
            }

            return cnt == n - 1 ? res : -1;
        }

        int Find(int x)
        {
            while (x != P[x])
            {
                x = P[x];
            }
            return x;
        }
    }
}

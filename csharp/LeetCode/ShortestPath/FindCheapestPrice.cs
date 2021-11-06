namespace LeetCode.ShortestPath.FindCheapestPrice
{
    using System;

    public class Solution
    {
        int INF = int.MaxValue / 2;
        int[] Dist;
        int[] Backup;
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            Dist = new int[n];
            Backup = new int[n];
            Array.Fill(Dist, INF);
            Dist[src] = 0;
            for (var i = 0; i <= k; i++)
            {
                Array.Copy(Dist, Backup, n);
                foreach (var f in flights)
                {
                    var u = f[0];
                    var v = f[1];
                    var w = f[2];
                    Dist[v] = Math.Min(Dist[v], Backup[u] + w);
                }
            }
            return Dist[dst] == INF ? -1 : Dist[dst];
        }
    }
}

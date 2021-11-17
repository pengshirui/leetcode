namespace LeetCode.UnionFind.NumIslands2
{
    using System.Collections.Generic;

    public class Solution
    {
        int[] p;
        int[,] Dxy = { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };
        HashSet<int> hs = new HashSet<int>();
        public IList<int> NumIslands2(int m, int n, int[][] positions)
        {
            p = new int[m * n];
            for (var i = 0; i < p.Length; i++) p[i] = i;

            var res = new int[positions.Length];

            var cnt = 0;
            for (var i = 0; i < positions.Length; i++)
            {
                var x = positions[i][0];
                var y = positions[i][1];
                var k = x * n + y;
                if (hs.Contains(k))
                {
                    res[i] = cnt;
                    continue;
                };
                hs.Add(k);
                var change = 1;
                for (var d = 0; d < 4; d++)
                {
                    var x0 = x + Dxy[d, 0];
                    var y0 = y + Dxy[d, 1];
                    var k0 = x0 * n + y0;
                    if (x0 < 0 || x0 >= m || y0 < 0 || y0 >= n) continue;
                    if (!hs.Contains(k0)) continue;
                    var rk = Find(k);
                    var rk0 = Find(k0);
                    if (rk != rk0)
                    {
                        p[rk] = rk0;
                        change--;
                    }
                }
                cnt += change;
                res[i] = cnt;
            }
            return res;
        }

        int Find(int x)
        {
            while (x != p[x])
            {
                x = p[x];
            }
            return x;
        }
    }
}

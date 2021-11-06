namespace LeetCode.Medium.ShortestPath
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        private readonly int[][] Dirs = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 },
        };

        public int ShortestPath(int[][] grid, int k)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            if (m - 1 == 0 && n - 1 == 0) return 0;
            var res = 0;
            var q = new Queue<(int, int, int)>();
            var v = new bool[m, n, k + 1];
            q.Enqueue((0, 0, k));
            v[0, 0, k] = true;

            while (q.Any())
            {
                var c = q.Count;
                res++;
                while (c-- > 0)
                {
                    var (x, y, z) = q.Dequeue();
                    foreach (var d in Dirs)
                    {
                        var newX = x + d[0];
                        var newY = y + d[1];
                        if (newX == m - 1 && newY == n - 1) return res;
                        if (newX < 0 || newX >= m || newY < 0 || newY >= n) continue;

                        var newZ = grid[newX][newY] == 1 ? z - 1 : z;
                        if (grid[newX][newY] == 1 && z <= 0 || v[newX, newY, newZ]) continue;
                        q.Enqueue((newX, newY, newZ));
                        v[newX, newY, newZ] = true;
                    }
                }
            }
            return -1;
        }
    }
}

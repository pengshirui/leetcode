namespace LeetCode.Medium.MaxAreaOfIsland
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        private int M;
        private int N;
        private readonly int[][] Dirs = new int[][]
        {
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 },
        };
        public int MaxAreaOfIsland(int[][] grid)
        {
            M = grid.Length;
            N = grid[0].Length;

            var visited = new bool[M, N];
            var res = 0;
            for (var i = 0; i < M; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    var area = BFS(grid, i, j, visited);
                    res = Math.Max(res, area);
                }
            }
            return res;
        }

        int BFS(int[][] grid, int i, int j, bool[,] visited)
        {
            if (grid[i][j] == 0) return 0;
            if (visited[i, j]) return 0;

            var q = new Queue<(int, int)>();
            q.Enqueue((i, j));
            visited[i, j] = true;
            var res = 0;
            while (q.Any())
            {
                var (x, y) = q.Dequeue();
                res++;
                foreach (var d in Dirs)
                {
                    var s = x + d[0];
                    var t = y + d[1];
                    if (s < 0 || s >= M || t < 0 || t >= N || grid[s][t] == 0 || visited[s, t]) continue;
                    q.Enqueue((s, t));
                    visited[s, t] = true;
                }
            }

            return res;
        }
    }
}

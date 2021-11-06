namespace LeetCode.Medium.GetFood
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
        public int GetFood(char[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var start = (-1, -1);
            var ends = new List<(int, int)>();
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (grid[i][j] == '*')
                    {
                        start = (i, j);
                    }
                    else if (grid[i][j] == '#')
                    {
                        ends.Add((i, j));
                    }
                }
            }
            if (start == (-1, -1) || !ends.Any()) return -1;
            var res = 0;
            var v1 = new HashSet<(int, int)>();
            var v2 = new HashSet<(int, int)>();

            var q1 = new Queue<(int, int)>();
            q1.Enqueue(start);
            v1.Add(start);
            var q2 = new Queue<(int, int)>();
            ends.ForEach(e =>
            {
                q2.Enqueue(e);
                v2.Add(e);
            });
            while (q1.Any() && q2.Any())
            {
                var count = q1.Count;
                while (count-- > 0)
                {
                    var (x, y) = q1.Dequeue();
                    foreach (var d in Dirs)
                    {
                        var newX = x + d[0];
                        var newY = y + d[1];
                        if (newX < 0 || newX >= m || newY < 0 || newY >= n || v1.Contains((newX, newY)) || grid[newX][newY] == 'X') continue;
                        q1.Enqueue((newX, newY));
                        v1.Add((newX, newY));
                    }
                }
                res++;
                if (q1.Intersect(q2).Any())
                {
                    return res;
                }
                count = q2.Count;
                while (count-- > 0)
                {
                    var (x, y) = q2.Dequeue();
                    foreach (var d in Dirs)
                    {
                        var newX = x + d[0];
                        var newY = y + d[1];
                        if (newX < 0 || newX >= m || newY < 0 || newY >= n || v2.Contains((newX, newY)) || grid[newX][newY] == 'X') continue;
                        q2.Enqueue((newX, newY));
                        v2.Add((newX, newY));
                    }
                }
                res++;
                if (q1.Intersect(q2).Any())
                {
                    return res;
                }
            }
            return -1;
        }
    }
}

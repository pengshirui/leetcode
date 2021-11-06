namespace LeetCode.Medium.UniquePaths
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        private readonly int[][] Dirs1 = new int[][]
        {
            new int[] { 0, 1 }, // right
            new int[] { 1, 0 }, // down
        };

        private readonly int[][] Dirs2 = new int[][]
        {
            new int[] { 0, -1 }, // left
            new int[] { -1, 0 }, // up
        };
        public int UniquePaths2(int m, int n)
        {
            var counts = new int[m, n];
            counts[m - 1, n - 1] = 1;
            var q = new Queue<(int, int)>();
            var visited = new HashSet<(int, int)>();
            q.Enqueue((m - 1, n - 1));
            visited.Add((m - 1, n - 1));
            while (q.Any())
            {
                var count = q.Count();
                while (count-- > 0)
                {
                    var (x, y) = q.Dequeue();
                    var steps = counts[x, y];
                    for (var i = 0; i < 2; i++)
                    {
                        var x2 = x + Dirs1[i][0];
                        var y2 = y + Dirs1[i][1];
                        if (x2 < 0 || x2 >= m || y2 < 0 || y2 >= n) continue;
                        steps += counts[x2, y2];
                    }
                    counts[x, y] = steps;
                    for (var i = 0; i < 2; i++)
                    {
                        var x3 = x + Dirs2[i][0];
                        var y3 = y + Dirs2[i][1];
                        if (x3 < 0 || x3 >= m || y3 < 0 || y3 >= n || visited.Contains((x3, y3))) continue;
                        q.Enqueue((x3, y3));
                        visited.Add((x3, y3));
                    }
                }
            }
            return counts[0, 0];
        }
        public int UniquePaths(int m, int n)
        {
            if (m == 1 || n == 1)
            {
                return 1;
            }

            --m;
            --n;

            if (m < n)
            {
                int t = m;
                m = n;
                n = t;
            }

            long r = 1;

            for (int i = m + 1, j = 1; j <= n; i++, j++)
            {
                r *= i;
                r /= j;
            }

            return (int)r;
        }
    }
}

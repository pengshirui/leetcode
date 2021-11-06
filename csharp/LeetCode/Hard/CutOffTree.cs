namespace LeetCode.Hard
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solution
    {
        readonly int[][] Directions = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 }
        };

        int m = 0;
        int n = 0;

        public int CutOffTree(IList<IList<int>> forest)
        {
            m = forest.Count;
            n = forest[0].Count;

            // (height, x, y)
            var trees = new List<(int, int, int)>();
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (forest[i][j] > 1)
                    {
                        trees.Add((forest[i][j], i, j));
                    }
                }
            }

            trees.Sort();

            var x = 0;
            var y = 0;
            var totalSteps = 0;
            foreach (var (_, tx, ty) in trees)
            {
                var steps = BFS(forest, x, y, tx, ty);
                if (steps == -1)
                {
                    return -1;
                }
                totalSteps += steps;
                x = tx;
                y = ty;
            }

            return totalSteps;
        }

        private int BFS(IList<IList<int>> forest, int x, int y, int tx, int ty)
        {
            var visited = new bool[m, n];
            var q = new Queue<(int, int)>();
            q.Enqueue((x, y));

            var steps = 0;
            while (q.Any())
            {
                var count = q.Count;
                while (count-- > 0)
                {
                    var (cx, cy) = q.Dequeue();
                    if (cx == tx && cy == ty)
                    {
                        return steps;
                    }

                    foreach (var d in Directions)
                    {
                        var nx = cx + d[0];
                        var ny = cy + d[1];

                        if (nx < 0 || nx >= m ||
                            ny < 0 || ny >= n ||
                            visited[nx, ny] ||
                            forest[nx][ny] == 0)
                        {
                            continue;
                        }

                        visited[nx, ny] = true;
                        q.Enqueue((nx, ny));
                    }

                }
                steps++;
            }
            return -1;
        }
    }
}

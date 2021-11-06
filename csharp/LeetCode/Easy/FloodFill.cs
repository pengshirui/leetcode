namespace LeetCode.Easy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public partial class Solution
    {
        readonly int[][] Directions = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 },
        };

        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            var m = image.Length;
            var n = image[0].Length;
            var oldColor = image[sr][sc];
            if (sr < 0 || sr >= m || sc < 0 || sc >= n || oldColor == newColor)
            {
                return image;
            }

            // (x, y)
            var q = new Queue<(int, int)>();
            q.Enqueue((sr, sc));
            image[sr][sc] = newColor;
            var visited = new bool[m, n];
            visited[sr, sc] = true;

            while (q.Any())
            {
                var count = q.Count;
                while (count-- > 0)
                {
                    var (x, y) = q.Dequeue();
                    foreach (var d in Directions)
                    {
                        var nx = x + d[0];
                        var ny = y + d[1];
                        if (nx < 0 || nx >= m || ny < 0 || ny >= n || image[nx][ny] != oldColor || visited[nx, ny])
                        {
                            continue;
                        }
                        q.Enqueue((nx, ny));
                        image[nx][ny] = newColor;
                        visited[nx, ny] = true;
                    }

                }
            }

            return image;
        }
    }
}

namespace LeetCode.Hard.ShortestDistance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        private readonly int[][] Directions = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 },
        };

        public int ShortestDistance(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var buildings = new List<(int, int)>();

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        buildings.Add((i, j));
                    }
                }
            }

            var distances = new int[m, n];
            var reach = new int[m, n];
            foreach (var building in buildings)
            {
                var queue = new Queue<(int, int)>();
                var visited = new bool[m, n];
                queue.Enqueue(building);
                visited[building.Item1, building.Item2] = true;
                var level = 1;
                while (queue.Any())
                {
                    var count = queue.Count;
                    while (count-- > 0)
                    {
                        var (x, y) = queue.Dequeue();

                        for (var i = 0; i < 4; i++)
                        {
                            var newX = x + Directions[i][0];
                            var newY = y + Directions[i][1];
                            if (newX < 0 || newX >= m || newY < 0 || newY >= n || visited[newX, newY] || grid[newX][newY] != 0)
                            {
                                continue;
                            }
                            queue.Enqueue((newX, newY));
                            visited[newX, newY] = true;
                            distances[newX, newY] += level;
                            reach[newX, newY]++;
                        }
                    }

                    level++;
                }
            }
            var shortestDis = int.MaxValue;
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (grid[i][j] == 0 && reach[i, j] == buildings.Count)
                    {
                        shortestDis = Math.Min(shortestDis, distances[i, j]);
                    }
                }
            }
            return shortestDis == int.MaxValue ? -1 : shortestDis;

        }
    }
}

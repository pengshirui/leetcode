using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public int MaxDistance(int[][] grid)
        {
            var queue = new Queue<(int, int)>();
            var mark = new int[grid.Length, grid[0].Length];
            for (var i = 0; i < grid?.Length; i++)
            {
                for (var j = 0; j < grid[i]?.Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        queue.Enqueue((i, j));
                        mark[i, j] = 1;
                    }
                }
            }

            var maxDis = 0;
            while (queue.Any())
            {
                var count = queue.Count;
                while (count > 0)
                {
                    var island = queue.Dequeue();
                    var m = mark[island.Item1, island.Item2] + 1;
                    // go top
                    if (island.Item1 - 1 >= 0 && mark[island.Item1 - 1, island.Item2] == 0)
                    {
                        queue.Enqueue((island.Item1 - 1, island.Item2));
                        mark[island.Item1 - 1, island.Item2] = m;
                        maxDis = Math.Max(maxDis, m);
                    }
                    // go bottom
                    if (island.Item1 + 1 < grid.Length && mark[island.Item1 + 1, island.Item2] == 0)
                    {
                        queue.Enqueue((island.Item1 + 1, island.Item2));
                        mark[island.Item1 + 1, island.Item2] = m;
                        maxDis = Math.Max(maxDis, m);
                    }
                    // go left
                    if (island.Item2 - 1 >= 0 && mark[island.Item1, island.Item2 - 1] == 0)
                    {
                        queue.Enqueue((island.Item1, island.Item2 - 1));
                        mark[island.Item1, island.Item2 - 1] = m;
                        maxDis = Math.Max(maxDis, m);
                    }
                    // go right
                    if (island.Item2 + 1 < grid[island.Item1].Length && mark[island.Item1, island.Item2 + 1] == 0)
                    {
                        queue.Enqueue((island.Item1, island.Item2 + 1));
                        mark[island.Item1, island.Item2 + 1] = m;
                        maxDis = Math.Max(maxDis, m);
                    }

                    count--;
                }
            }

            return maxDis - 1;
        }
    }
}

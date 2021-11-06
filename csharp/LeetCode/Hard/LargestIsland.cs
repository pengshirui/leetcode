namespace LeetCode.Hard.LargestIsland
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        private int[] Parents;
        private int[] Areas;
        private readonly int[][] Dirs = new int[][] { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };
        public int LargestIsland(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            Parents = new int[m * n];
            Areas = new int[m * n];

            for (var i = 0; i < Parents.Length; i++)
            {
                Parents[i] = i;
            }

            for (var i = 0; i < m; i++)
            {
                for (var j = 1; j < n; j++)
                {
                    if (grid[i][j - 1] == 1 && grid[i][j] == 1)
                    {
                        var key1 = i * m + j;
                        var key2 = i * m + j - 1;
                        Union(key1, key2);
                    }
                }
            }

            for (var j = 0; j < n; j++)
            {
                for (var i = 1; i < m; i++)
                {
                    if (grid[i - 1][j] == 1 && grid[i][j] == 1)
                    {
                        var key1 = (i - 1) * m + j;
                        var key2 = i * m + j;
                        Union(key1, key2);
                    }
                }
            }

            var result = 0;
            for (var i = 0; i < Parents.Length; i++)
            {
                var parent = Find(i);
                Areas[parent]++;

                result = Math.Max(result, Areas[parent]);
            }

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1) continue;
                    var k1 = i * m + j;
                    Areas[k1] = 1;
                    var hs = new HashSet<int>();
                    for (var d = 0; d < 4; d++)
                    {
                        var x = i + Dirs[d][0];
                        var y = j + Dirs[d][1];
                        if (x < 0 || x >= m || y < 0 || y >= n || grid[x][y] == 0) continue;
                        var k2 = Find(x * m + y);
                        if (hs.Contains(k2)) continue;
                        Areas[k1] += Areas[k2];
                        hs.Add(k2);
                        result = Math.Max(result, Areas[k1]);
                    }
                }
            }

            return result;
        }

        void Union(int x, int y)
        {
            var p1 = Find(x);
            var p2 = Find(y);
            Parents[p1] = p2;
        }

        int Find(int x)
        {
            if (Parents[x] != x)
            {
                Parents[x] = Find(Parents[x]);
            }
            return Parents[x];
        }
    }
}

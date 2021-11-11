namespace LeetCode.BFS.ShortestPathAllKeys
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        int[,] Ds =
        {
            { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 }
        };

        string goal = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public int ShortestPathAllKeys(params string[] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var q = new Queue<(int, int, string)>();
            var vis = new HashSet<string>();
            var start = goal.ToCharArray();
            var i0 = 0;
            var j0 = 0;
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var c = grid[i][j];
                    if (c == '@')
                    {
                        i0 = i;
                        j0 = j;
                    }
                    else if (char.IsLower(c))
                    {
                        start[c - 'a'] = c;
                    }
                }
            }
            var st = new string(start);
            q.Enqueue((i0, j0, st));
            vis.Add($"{i0}{st}{j0}");

            var res = 0;
            while (q.Any())
            {
                var c = q.Count;
                while (c-- > 0)
                {
                    var (x, y, k) = q.Dequeue();
                    if (k == goal)
                    {
                        return res;
                    }
                    for (var i = 0; i < 4; i++)
                    {
                        var x1 = x + Ds[i, 0];
                        var y1 = y + Ds[i, 1];
                        if (x1 < 0 || x1 >= m || y1 < 0 || y1 >= n || grid[x1][y1] == '#') continue;
                        if (char.IsUpper(grid[x1][y1]) && !HasKey(grid[x1][y1], k)) continue;
                        if (char.IsLower(grid[x1][y1]))
                        {
                            var k1 = PickKey(grid[x1][y1], k);
                            var s1 = $"{x1}{k1}{y1}";
                            if (vis.Contains(s1)) continue;

                            vis.Add(s1);
                            q.Enqueue((x1, y1, k1));
                        }
                        else
                        {
                            var s1 = $"{x1}{k}{y1}";
                            if (vis.Contains(s1)) continue;

                            vis.Add(s1);
                            q.Enqueue((x1, y1, k));
                        }
                    }
                }
                res++;
            }

            return -1;
        }

        bool HasKey(char l, string keys)
        {
            return keys[l - 'A'] == l;
        }

        string PickKey(char k, string keys)
        {
            var arr = keys.ToCharArray();
            arr[k - 'a'] = char.ToUpper(k);
            return new string(arr);
        }
    }
}

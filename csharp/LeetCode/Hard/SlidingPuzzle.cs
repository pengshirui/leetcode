namespace LeetCode.Hard.SlidingPuzzle
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        private readonly int[][] Dirs = new int[][]
        {
            new int[] {-1, 0},
            new int[] {1, 0},
            new int[] {0, -1},
            new int[] {0, 1},
        };

        public int SlidingPuzzle(int[][] board)
        {
            var m = 2;
            var n = 3;
            var current = string.Empty;
            var goal = "123450";
            var result = 0;
            var sx = 0;
            var sy = 0;
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    current += board[i][j];
                    if (board[i][j] == 0)
                    {
                        sx = i;
                        sy = j;
                    }
                }
            }
            if (current == goal)
            {
                return result;
            }
            var q = new Queue<(string, int, int)>();
            q.Enqueue((current, sx, sy));
            var visited = new HashSet<string>();
            visited.Add(current.ToString());
            while (q.Any())
            {
                result++;
                var count = q.Count();
                while (count-- > 0)
                {
                    var (str, x, y) = q.Dequeue();
                    var index = x * n + y;
                    for (var i = 0; i < 4; i++)
                    {
                        var x2 = x + Dirs[i][0];
                        var y2 = y + Dirs[i][1];
                        var index2 = x2 * n + y2;
                        if (x2 < 0 || x2 >= m || y2 < 0 || y2 >= n) continue;
                        var newStr = Swap(str, index, index2);
                        if (visited.Contains(newStr)) continue;
                        if (newStr == goal)
                        {
                            return result;
                        }
                        q.Enqueue((newStr, x2, y2));
                        visited.Add(newStr);
                    }
                }
            }

            return -1;
        }

        string Swap(string nums, int x, int y)
        {
            var n = nums.ToCharArray();
            var t = n[x];
            n[x] = n[y];
            n[y] = t;
            return new string(n);
        }
    }
}

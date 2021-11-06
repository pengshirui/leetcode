namespace LeetCode.BFS.SlidingPuzzle
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        int m, n;
        int[,] d = { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };
        HashSet<string> hs = new HashSet<string>();

        public int SlidingPuzzle(int[][] board)
        {
            m = board.Length;
            n = board[0].Length;
            var end = "123450";
            // (x, y, state)
            var q = new Queue<(int, int, string)>();

            var x0 = 0;
            var y0 = 0;
            var s0 = string.Empty;
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    s0 += board[i][j];
                    if (board[i][j] == 0)
                    {
                        x0 = i;
                        y0 = j;
                    }
                }
            }
            q.Enqueue((x0, y0, s0));
            hs.Add(s0);

            var res = 0;
            while (q.Any())
            {
                var c = q.Count;
                while (c-- > 0)
                {
                    var (x, y, s) = q.Dequeue();
                    if (s == end)
                    {
                        return res;
                    }

                    for (var i = 0; i < 4; i++)
                    {
                        var x2 = x + d[i, 0];
                        var y2 = y + d[i, 1];

                        if (x2 < 0 || x2 >= m || y2 < 0 || y2 >= n) continue;
                        var s2 = Swap(s, x * n + y, x2 * n + y2);
                        if (hs.Contains(s2)) continue;
                        q.Enqueue((x2, y2, s2));
                        hs.Add(s2);
                    }
                }

                res++;
            }

            return -1;
        }

        string Swap(string s, int i, int j)
        {
            var a = s.ToCharArray();
            var t = a[i];
            a[i] = a[j];
            a[j] = t;
            return new string(a);
        }
    }
}

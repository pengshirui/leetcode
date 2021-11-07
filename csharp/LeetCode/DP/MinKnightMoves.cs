namespace LeetCode.DP.MinKnightMoves
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        Queue<(int, int)> q = new Queue<(int, int)>();
        HashSet<(int, int)> hs = new HashSet<(int, int)>();
        int[] mvs = { 1, 2 };
        int[,] dp;
        int INF = int.MaxValue / 2;
        public int MinKnightMoves(int x, int y)
        {
            return DP(x, y);
        }

        int BFS(int x, int y)
        {
            if (x < 0 || y < 0) return BFS(Math.Abs(x), Math.Abs(y));
            q.Enqueue((0, 0));
            hs.Add((0, 0));
            var res = 0;
            while (q.Any())
            {
                var c = q.Count;
                while (c-- > 0)
                {
                    var (u, v) = q.Dequeue();
                    if (u == x && v == y) return res;

                    for (var i = -1; i < 2; i += 2)
                    {
                        for (var j = -1; j < 2; j += 2)
                        {
                            for (var k = 0; k < 2; k++)
                            {
                                var u1 = u + i * mvs[k];
                                var v1 = v + j * mvs[1 - k];
                                if (u1 < -1 || v1 < -1 || hs.Contains((u1, v1))) continue;
                                q.Enqueue((u1, v1));
                                hs.Add((u1, v1));
                            }
                        }
                    }
                }

                res++;
            }
            return res;
        }

        int DP(int x, int y)
        {
            var m = Math.Max(x, 2) + 1;
            var n = Math.Max(y, 2) + 1;
            dp = new int[m, n];
            dp[0, 1] = dp[1, 0] = 3;
            dp[0, 2] = dp[2, 0] = dp[1, 1] = 2;
            for (var i = 0; i <= x; i++)
            {
                for (var j = 0; j <= y; j++)
                {
                    if (i + j < 3) continue;
                    dp[i, j] = INF;
                    if (i - 2 >= 0 && j - 1 >= 0) dp[i, j] = Math.Min(dp[i - 2, j - 1], dp[i, j]) + 1;
                    if (i - 1 >= 0 && j - 2 >= 0) dp[i, j] = Math.Min(dp[i - 1, j - 2], dp[i, j]) + 1;
                }
            }
            return dp[x, y];
        }
    }
}

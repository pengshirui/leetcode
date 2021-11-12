namespace LeetCode.DP.CalculateMinimumHP
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        int INF = int.MaxValue / 2;
        int[,] f;
        public int CalculateMinimumHP(int[][] dungeon)
        {
            var m = dungeon.Length;
            var n = dungeon[0].Length;
            f = new int[m + 1, n + 1];
            for (var i = 0; i <= m; i++)
                for (var j = 0; j <= n; j++) f[i, j] = INF;

            f[m, n - 1] = 1;
            f[m - 1, n] = 1;

            for (var i = m - 1; i >= 0; i--)
            {
                for (var j = n - 1; j >= 0; j--)
                {
                    var hp = Math.Min(f[i, j + 1], f[i + 1, j]) - dungeon[i][j];
                    f[i, j] = hp <= 0 ? 1 : hp;
                }
            }
            return f[0, 0];
        }
    }
}

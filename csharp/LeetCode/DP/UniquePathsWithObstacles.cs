namespace LeetCode.DP.UniquePathsWithObstacles
{
    public class Solution
    {
        int m, n;
        public int UniquePathsWithObstacles(int[][] g)
        {
            m = g.Length;
            n = g[0].Length;

            var f = new int[m + 1, n + 1];
            f[1, 1] = 1 - g[0][0];
            for (var i = 1; i <= m; i++)
            {
                for (var j = 1; j <= n; j++)
                {
                    if (i == j && i == 1) continue;
                    if (g[i - 1][j - 1] == 1) continue;
                    f[i, j] = f[i - 1, j] + f[i, j - 1];
                }
            }

            return f[m, n];
        }
    }
}

namespace LeetCode.DP.UniquePaths
{
    public class Solution
    {
        public int UniquePaths(int m, int n)
        {
            var f = new int[m + 1, n + 1];
            f[1, 1] = 1;
            for (var i = 1; i <= m; i++)
            {
                for (var j = 1; j <= n; j++)
                {
                    if (i == j && i == 1) continue;
                    f[i, j] = f[i - 1, j] + f[i, j - 1];
                }
            }
            return f[m, n];
        }
    }
}

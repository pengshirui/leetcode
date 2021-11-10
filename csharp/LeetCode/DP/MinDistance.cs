namespace LeetCode.DP.MinDistance
{
    using System;

    public class Solution
    {
        int m, n;
        int[,] f;
        public int MinDistance(string word1, string word2)
        {
            m = word1.Length;
            n = word2.Length;
            f = new int[m + 1, n + 1];
            // convert w1[i] to w2[0]
            for (var i = 1; i <= m; i++) f[i, 0] = i;

            // convert w1[0] to w2[j]
            for (var j = 1; j <= n; j++) f[0, j] = j;

            for (var i = 1; i <= m; i++)
            {
                for (var j = 1; j <= n; j++)
                {
                    f[i, j] = Math.Min(f[i - 1, j], f[i, j - 1]) + 1;
                    var d = word1[i - 1] == word2[j - 1] ? 0 : 1;
                    f[i, j] = Math.Min(f[i, j], f[i - 1, j - 1] + d);
                }
            }
            return f[m, n];
        }
    }
}

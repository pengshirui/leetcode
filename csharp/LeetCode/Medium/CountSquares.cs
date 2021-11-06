namespace LeetCode.Medium.CountSquares
{
    using System;

    public class Solution
    {
        public int CountSquares(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;

            // dp[i,j]: edge of largest square with bottom right corner at (i, j)
            var dp = new int[m, n];
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0) continue;
                    var top = i - 1 >= 0 ? dp[i - 1, j] : 0;
                    var left = j - 1 >= 0 ? dp[i, j - 1] : 0;
                    var topLeft = i - 1 >= 0 && j - 1 >= 0 ? dp[i - 1, j - 1] : 0;
                    var d = Math.Min(top, left);
                    d = Math.Min(d, topLeft);
                    dp[i, j] = d + 1;
                }
            }

            var result = 0;
            foreach (var i in dp) result += i;
            return result;
        }
    }
}

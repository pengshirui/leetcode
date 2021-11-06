namespace LeetCode.Hard
{
    using System;

    public partial class Solution
    {
        public int LongestIncreasingPath(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;
            var memo = new int[m][];

            for (var i = 0; i < m; i++)
            {
                memo[i] = new int[n];
            }

            var ans = 1;
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    ans = Math.Max(ans, GetLongestPath(matrix, i, j, memo));
                }
            }

            return ans;
        }

        int GetLongestPath(int[][] matrix, int i, int j, int[][] memo)
        {
            if (memo[i][j] != 0)
            {
                return memo[i][j];
            }
            // go top 
            var t = 1;
            if (i - 1 >= 0 && matrix[i - 1][j] > matrix[i][j])
            {
                t = GetLongestPath(matrix, i - 1, j, memo) + 1;
            }
            // go bottom 
            var b = 1;
            if (i + 1 < matrix.Length && matrix[i + 1][j] > matrix[i][j])
            {
                b = GetLongestPath(matrix, i + 1, j, memo) + 1;
            }
            // go left 
            var l = 1;
            if (j - 1 >= 0 && matrix[i][j - 1] > matrix[i][j])
            {
                l = GetLongestPath(matrix, i, j - 1, memo) + 1;
            }
            // go right 
            var r = 1;
            if (j + 1 < matrix[i].Length && matrix[i][j + 1] > matrix[i][j])
            {
                r = GetLongestPath(matrix, i, j + 1, memo) + 1;
            }
            var max1 = Math.Max(l, r);
            var max2 = Math.Max(b, t);
            var max = Math.Max(max1, max2);
            memo[i][j] = max;
            return max;
        }
    }
}

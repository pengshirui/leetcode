namespace LeetCode.Medium
{
    public class NumMatrix
    {
        int[,] sum;
        int m, n;

        public NumMatrix(int[][] matrix)
        {
            m = matrix.Length;
            n = matrix[0].Length;
            sum = new int[m + 1, n + 1];
            for (var i = 1; i <= m; i++)
            {
                for (var j = 1; j <= n; j++)
                {
                    sum[i, j] = matrix[i - 1][j - 1] + sum[i - 1, j] + sum[i, j - 1] - sum[i - 1, j - 1];
                }
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            var a = sum[row2 + 1, col2 + 1];
            var b = sum[row1, col2 + 1];
            var c = sum[row2 + 1, col1];
            var d = sum[row1, col1];
            return a - b - c + d;
        }
    }
}

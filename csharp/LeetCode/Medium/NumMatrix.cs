namespace LeetCode.Medium
{
    public class NumMatrix
    {
        private readonly int[][] Memo;
        public NumMatrix(int[][] matrix)
        {
            Memo = new int[matrix.Length][];

            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[i].Length; j++)
                {
                    if (j == 0)
                    {
                        Memo[i] = new int[matrix[i].Length];
                    }
                    var a = i - 1 >= 0 ? Memo[i - 1][j] : 0;
                    var b = j - 1 >= 0 ? Memo[i][j - 1] : 0;
                    var c = i - 1 >= 0 && j - 1 >= 0 ? Memo[i - 1][j - 1] : 0;
                    Memo[i][j] = a + b - c + matrix[i][j];
                }
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            var a = row1 - 1 >= 0 && col1 - 1 >= 0 ? Memo[row1 - 1][col1 - 1] : 0;
            var b = col1 - 1 >= 0 ? Memo[row2][col1 - 1] : 0;
            var c = row1 - 1 >= 0 ? Memo[row1 - 1][col2] : 0;
            var d = Memo[row2][col2];

            return d - c - b + a;
        }
    }
}

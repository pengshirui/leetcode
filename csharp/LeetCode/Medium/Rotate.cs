namespace LeetCode.Medium
{
    public partial class Solution
    {
        public void Rotate(int[][] matrix)
        {
            var m = matrix.Length;
            var top = 0;
            var bottom = m - 1;
            while (top < bottom)
            {
                var t = matrix[top];
                matrix[top] = matrix[bottom];
                matrix[bottom] = t;
                top++;
                bottom--;
            }

            for (var i = 0; i < m; i++)
            {
                for (var j = i + 1; j < m; j++)
                {
                    var t = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = t;
                }
            }
        }
    }
}

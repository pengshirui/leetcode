namespace LeetCode.Medium.SearchMatrix
{
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;

            var i = m - 1;
            var j = 0;
            while (i >= 0 && j < n)
            {
                if (matrix[i][j] == target) return true;
                if (matrix[i][j] > target)
                {
                    i--;
                }
                else
                {
                    j++;
                }
            }
            return false;
        }
    }
}

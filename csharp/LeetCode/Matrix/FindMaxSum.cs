namespace LeetCode.Matrix.FindMaxSum
{
    using System;

    public class Solution
    {
        public int[] FindMaxSum(int[][] matrix, int k)
        {
            var res = new int[3];
            var m = matrix.Length;
            var n = matrix[0].Length;
            var sum = 0;
            for (var i = k; i < m - k; i++)
                for (var j = k; j < n - k; j++)
                {
                    sum = GetSum(matrix, i, j, k);
                    Add(res, sum);
                }
            return res;
        }

        public int[] FindMaxSum2(int[][] matrix, int k)
        {
            var res = new int[3];
            var m = matrix.Length;
            var n = matrix[0].Length;
            for (var i = k; i < m - k; i++)
                for (var j = k; j < n - k; j++)
                {
                    var sum = GetSum(matrix, i, j, k);
                    Add(res, sum);
                }
            return res;
        }

        void Add(int[] res, int sum)
        {
            if (sum >= res[0])
            {
                var t = res[0];
                res[0] = sum;
                sum = t;
            }
            if (sum >= res[1])
            {
                var t = res[1];
                res[1] = sum;
                sum = t;
            }
            if (sum >= res[2])
            {
                var t = res[2];
                res[2] = sum;
            }
        }

        int GetSum(int[][] matrix, int x, int y, int k)
        {
            var s = 0;
            for (var i = x - k; i <= x + k; i++)
            {
                var diff = Math.Abs(i - x);
                for (var j = y - k + diff; j <= y + k - diff; j++)
                {
                    s += matrix[i][j];
                }
            }

            return s;
        }
    }
}

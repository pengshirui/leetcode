namespace LeetCode.Medium.MaxPoints
{
    using System;
    using System.Linq;

    public class Solution
    {
        public long MaxPoints(int[][] points)
        {
            var m = points.Length;
            var n = points[0].Length;
            var prev = new int[n];
            for (var i = 0; i < m; i++)
            {
                var lefts = prev;
                var rights = prev;
                for (var j = 0; j < n; j++)
                {
                    var left = j - 1 >= 0 ? lefts[j - 1] : 0;
                    lefts[j] = Math.Max(lefts[j], left - 1);

                    var k = n - 1 - j;
                    var right = k + 1 < n ? rights[k + 1] : 0;
                    rights[k] = Math.Max(rights[k], right - 1);
                }
                for (var j = 0; j < n; j++)
                {
                    prev[j] = Math.Max(lefts[j], rights[j]) + points[i][j];
                }
            }

            return prev.Max();
        }
    }
}

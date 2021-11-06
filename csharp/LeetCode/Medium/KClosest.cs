namespace LeetCode.Medium
{
    using System;

    public partial class Solution
    {
        public int[][] KClosest(int[][] points, int k)
        {
            var distances = new (int, int)[points.GetLength(0)];

            for (var i = 0; i < distances.Length; i++)
            {
                distances[i] = (i, points[i][0] * points[i][0] + points[i][1] * points[i][1]);
            }
            Array.Sort(distances, (a, b) => a.Item2 - b.Item2);

            var ans = new int[k][];
            for (var j = 0; j < k; j++)
            {
                ans[j] = points[distances[j].Item1];
            }

            return ans;
        }
    }
}

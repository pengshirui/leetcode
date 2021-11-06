namespace LeetCode.Hard.FindMaxValueOfEquation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public int FindMaxValueOfEquation(int[][] points, int k)
        {
            var link = new LinkedList<(int, int)>();
            int res = int.MinValue;
            foreach (var point in points)
            {
                while (link.Any() && point[0] - link.First.Value.Item2 > k)
                {
                    link.RemoveFirst();
                }
                if (link.Any())
                {
                    res = Math.Max(res, link.First.Value.Item1 + point[0] + point[1]);
                }
                while (link.Any() && point[1] - point[0] > link.Last.Value.Item1)
                {
                    link.RemoveLast();
                }
                link.AddLast((point[1] - point[0], point[0]));
            }
            return res;
        }
    }
}

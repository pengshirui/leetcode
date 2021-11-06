namespace LeetCode.Medium.ValidSquare
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            var list = new List<long>
            {
                GetLength(p1, p2),
                GetLength(p1, p3),
                GetLength(p1, p4),
                GetLength(p2, p3),
                GetLength(p2, p4),
                GetLength(p3, p4),
            };
            var map = new Dictionary<long, int>();
            foreach (var l in list)
            {
                map.TryAdd(l, 0);
                map[l]++;
            }
            if (map.Count != 2) return false;
            var diag = map.Keys.Max();
            var edge = map.Keys.Min();
            return map[diag] == 2 && map[edge] == 4;
        }

        long GetLength(int[] x, int[] y)
        {
            return (x[0] - y[0]) * (x[0] - y[0]) + (x[1] - y[1]) * (x[1] - y[1]);
        }

    }
}

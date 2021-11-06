namespace LeetCode.Hard.GridIllumination
{
    using System.Collections.Generic;

    public class Solution
    {
        private int N;
        private readonly Dictionary<int, int> Rows = new Dictionary<int, int>();
        private readonly Dictionary<int, int> Cols = new Dictionary<int, int>();
        private readonly Dictionary<int, int> Dia = new Dictionary<int, int>();
        private readonly Dictionary<int, int> Adia = new Dictionary<int, int>();
        private readonly HashSet<(int, int)> Lamps = new HashSet<(int, int)>();
        public int[] GridIllumination(int n, int[][] lamps, int[][] queries)
        {
            N = n;
            foreach (var lamp in lamps)
            {
                var x = lamp[0];
                var y = lamp[1];
                if (Lamps.Contains((x, y))) continue;
                Rows.TryAdd(x, 0);
                Cols.TryAdd(y, 0);
                Dia.TryAdd(x - y, 0);
                Adia.TryAdd(x + y, 0);
                Rows[x]++;
                Cols[y]++;
                Dia[x - y]++;
                Adia[x + y]++;
                Lamps.Add((x, y));
            }
            var res = new int[queries.Length];
            for (var i = 0; i < queries.Length; i++)
            {
                var q = queries[i];
                var x = q[0];
                var y = q[1];
                var v1 = Rows.GetValueOrDefault(x, 0);
                var v2 = Cols.GetValueOrDefault(y, 0);
                var v3 = Dia.GetValueOrDefault(x - y, 0);
                var v4 = Adia.GetValueOrDefault(x + y, 0);
                if (v1 > 0 || v2 > 0 || v3 > 0 || v4 > 0)
                {
                    res[i] = 1;
                }
                if (i != queries.Length - 1) TurnOff(x, y);
            }
            return res;
        }

        private readonly int[] Moves = new int[] { 0, -1, 1 };
        void TurnOff(int x, int y)
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var p = x + Moves[i];
                    var q = y + Moves[j];
                    if (p < 0 || p >= N || q < 0 || q >= N || !Lamps.Contains((p, q))) continue;
                    Lamps.Remove((p, q));
                    Rows[p]--;
                    Cols[q]--;
                    Dia[p - q]--;
                    Adia[p + q]--;
                }
            }
        }
    }
}

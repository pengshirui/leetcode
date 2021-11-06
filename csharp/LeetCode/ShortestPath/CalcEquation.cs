namespace LeetCode.ShortestPath.CalcEquation
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        Dictionary<string, Dictionary<string, double>> D = new Dictionary<string, Dictionary<string, double>>();
        double[] Result;

        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            for (var i = 0; i < equations.Count; i++)
            {
                var p1 = equations[i][0];
                var p2 = equations[i][1];
                var v = values[i];
                D.TryAdd(p1, new Dictionary<string, double>());
                D[p1].Add(p2, v);
                D.TryAdd(p2, new Dictionary<string, double>());
                D[p2].Add(p1, 1 / v);
            }
            Result = new double[queries.Count];
            for (var i = 0; i < queries.Count; i++)
            {
                var q = queries[i];
                var p1 = q[0];
                var p2 = q[1];
                /*
                var r = BFS(p1, p2, new HashSet<string>());
                Result[i] = r;
                */
                DFS(1, p1, p2, new HashSet<string>(), i);
            }

            return Result;
        }

        void DFS(double res, string x, string y, HashSet<string> visited, int i)
        {
            if (!D.ContainsKey(x) || !D.ContainsKey(y))
            {
                Result[i] = -1;
                return;
            }
            if (x == y)
            {
                Result[i] = res;
                return;
            }
            visited.Add(x);
            foreach (var (k, v) in D[x])
            {
                if (visited.Contains(k)) continue;
                DFS(res * v, k, y, visited, i);
            }
        }

        double BFS(string p1, string p2, HashSet<string> Visited)
        {
            var q = new Queue<(string, double)>();
            q.Enqueue((p1, 1));
            while (q.Any())
            {
                var (k, v) = q.Dequeue();
                if (!D.ContainsKey(k)) continue;
                if (k == p2)
                {
                    return v;
                }
                foreach (var (key, value) in D[k])
                {
                    if (Visited.Contains(key)) continue;
                    Visited.Add(key);
                    q.Enqueue((key, value * v));
                }
            }
            return -1;
        }
    }
}

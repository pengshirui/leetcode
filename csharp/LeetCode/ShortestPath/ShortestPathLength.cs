namespace LeetCode.ShortestPath.ShortestPathLength
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public int ShortestPathLength(int[][] graph)
        {
            var n = graph.Count();
            var end = (1 << n) - 1;
            var visited = new bool[n, 1 << n];
            var q = new Queue<(int, int)>();
            for (var i = 0; i < graph.Length; i++)
            {
                q.Enqueue((i, 1 << i));
            }

            var res = 0;
            while (q.Any())
            {
                var count = q.Count();
                while (count-- > 0)
                {
                    var (node, state) = q.Dequeue();
                    if (state == end)
                    {
                        return res;
                    }
                    if (visited[node, state]) continue;
                    visited[node, state] = true;
                    foreach (var next in graph[node])
                    {
                        q.Enqueue((next, state | 1 << next));
                    }
                }
                res++;
            }
            return -1;
        }
    }
}

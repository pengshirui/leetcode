namespace LeetCode.BFS.NumBusesToDestination
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        Queue<int> q = new Queue<int>();
        Dictionary<int, List<int>> kv = new Dictionary<int, List<int>>();
        HashSet<int> visitedStop = new HashSet<int>();
        HashSet<int> visitedBus = new HashSet<int>();
        public int NumBusesToDestination(int[][] routes, int source, int target)
        {
            if (source == target) return 0;
            for (var i = 0; i < routes.Length; i++)
            {
                for (var j = 0; j < routes[i].Length; j++)
                {
                    // i: bus id;
                    // routes[i][j]: stop id;
                    kv.TryAdd(routes[i][j], new List<int>());
                    kv[routes[i][j]].Add(i);
                }
            }
            if (!kv.ContainsKey(target)) return -1;
            var res = 0;
            q.Enqueue(source);
            visitedStop.Add(source);

            while (q.Any())
            {
                var c = q.Count;
                while (c-- > 0)
                {
                    var stop = q.Dequeue();
                    if (stop == target)
                    {
                        return res;
                    }
                    Transfer(routes, stop);
                }
                res++;
            }

            return -1;
        }

        void Transfer(int[][] routes, int stop)
        {
            foreach (var bus in kv[stop])
            {
                if (visitedBus.Contains(bus)) continue;
                foreach (var next in routes[bus])
                {
                    if (visitedStop.Contains(next)) continue;
                    q.Enqueue(next);
                    visitedStop.Add(next);
                }

                visitedBus.Add(bus);
            }
        }
    }

}

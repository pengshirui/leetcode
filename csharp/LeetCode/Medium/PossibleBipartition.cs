namespace LeetCode.Medium.PossibleBipartition
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public bool PossibleBipartition(int n, int[][] dislikes)
        {
            if (n < 3 || dislikes.Length < 2) return true;

            var nodes = new Node[n + 1];
            for (var i = 1; i < n + 1; i++)
            {
                nodes[i] = new Node
                {
                    Id = i,
                };
            }
            foreach (var dis in dislikes)
            {
                var x = dis[0];
                var y = dis[1];
                nodes[x].Dislikes.Add(y);
                nodes[y].Dislikes.Add(x);
            }

            var visited = new bool[n + 1];
            for (var i = 1; i < nodes.Length; i++)
            {
                if (visited[i]) continue;
                nodes[i].Color = 1;
                var q = new Queue<int>();
                q.Enqueue(i);
                while (q.Any())
                {
                    var deq = q.Dequeue();
                    var cur = nodes[deq];
                    visited[deq] = true;
                    foreach (var d in cur.Dislikes)
                    {
                        var dislike = nodes[d];
                        if (dislike.Color == cur.Color) return false;
                        if (visited[d]) continue;
                        dislike.Color = cur.Color * -1;
                        q.Enqueue(d);
                    }
                }
            }
            return true;
        }
    }

    class Node
    {
        public int Id;
        // -1, 0, 1
        public int Color;
        public IList<int> Dislikes = new List<int>();
    }
}

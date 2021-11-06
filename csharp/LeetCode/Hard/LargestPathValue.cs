namespace LeetCode.Hard.LargestPathValue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public int LargestPathValue(string colors, int[][] edges)
        {
            if (string.IsNullOrWhiteSpace(colors))
            {
                return 0;
            }
            var nodes = new Node[colors.Length];
            for (var i = 0; i < colors.Length; i++)
            {
                nodes[i] = new Node
                {
                    Color = colors[i],
                };
                nodes[i].Counts[colors[i] - 'a']++;
            }

            foreach (var edge in edges)
            {
                var from = nodes[edge[0]];
                var to = nodes[edge[1]];
                from.Next.Add(to);
                to.Indegree++;
            }
            var visited = 0;

            var q = new Queue<Node>();
            foreach (var node in nodes)
            {
                if (node.Indegree == 0)
                {
                    q.Enqueue(node);
                }
            }

            var res = 0;
            while (q.Any())
            {
                var cur = q.Dequeue();
                res = Math.Max(res, cur.Counts.Max());
                visited++;
                foreach (var next in cur.Next)
                {
                    AddColors(cur, next);
                    next.Indegree--;
                    if (next.Indegree == 0)
                    {
                        q.Enqueue(next);
                    }
                }
            }

            return visited == nodes.Length ? res : -1;
        }

        void AddColors(Node cur, Node next)
        {
            for (var i = 0; i < 26; i++)
            {
                var one = i == next.Color - 'a' ? 1 : 0;
                next.Counts[i] = Math.Max(cur.Counts[i] + one, next.Counts[i]);
            }
        }

        class Node
        {
            public int Indegree;
            public IList<Node> Next = new List<Node>();
            public char Color;
            public int[] Counts = new int[26];
        }
    }
}

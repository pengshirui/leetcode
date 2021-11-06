namespace LeetCode.Medium
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solution
    {
        public int[] FindRedundantConnection(int[][] edges)
        {
            var kv = BuildTreeNodeGraph(edges);
            var hashSet = FindCircles(kv);

            for (var i = edges.Length - 1; i >= 0; i--)
            {
                var key1 = (edges[i][0], edges[i][1]);
                var key2 = (edges[i][1], edges[i][0]);
                if (hashSet.Contains(key1) || hashSet.Contains(key2))
                {
                    return edges[i];
                }

            }
            return Array.Empty<int>();
        }

        private HashSet<(int, int)> FindCircles(Dictionary<int, GraphTreeNode> kv)
        {
            var queue = new Queue<GraphTreeNode>();

            foreach (var node in kv.Values)
            {
                // remove one edge node
                if (node.Edges.Count == 1)
                {
                    queue.Enqueue(node);
                }
            }

            while (queue.Any())
            {
                var count = queue.Count;
                while (count > 0)
                {
                    var curNode = queue.Dequeue();
                    foreach (var node in curNode.Edges)
                    {
                        node.Edges.Remove(curNode);
                        if (node.Edges.Count == 1)
                        {
                            queue.Enqueue(node);
                        }
                    }
                    count--;
                }
            }

            var hs = new HashSet<(int, int)>();
            foreach (var node in kv.Values)
            {
                // remove one edge node
                if (node.Edges.Count > 1)
                {
                    foreach (var edge in node.Edges)
                    {
                        var data = (node.Val, edge.Val);
                        hs.Add(data);
                    }
                }
            }
            return hs;
        }

        private Dictionary<int, GraphTreeNode> BuildTreeNodeGraph(int[][] edges)
        {
            var kv = new Dictionary<int, GraphTreeNode>();
            foreach (var edge in edges)
            {
                var node1 = GetTreeNode(kv, edge[0]);
                var node2 = GetTreeNode(kv, edge[1]);
                node1.Edges.Add(node2);
                node2.Edges.Add(node1);
            }
            return kv;
        }

        GraphTreeNode GetTreeNode(Dictionary<int, GraphTreeNode> kv, int val)
        {
            if (kv.TryGetValue(val, out var treeNode))
            {
                return treeNode;
            }
            else
            {
                var newNode = new GraphTreeNode
                {
                    Val = val
                };
                kv[val] = newNode;
                return newNode;
            }
        }
    }

    class GraphTreeNode
    {
        public int Val { get; set; }
        public HashSet<GraphTreeNode> Edges = new HashSet<GraphTreeNode>();
    }
}

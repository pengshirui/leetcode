using System.Collections.Generic;
using System.Linq;
using LeetCode.DataStructures;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        Dictionary<Node, Node> kv = new Dictionary<Node, Node>();

        public Node CloneGraph(Node node)
        {
            if (node == null)
            {
                return null;
            }
            if (this.kv.TryGetValue(node, out Node clonedNode))
            {
                // nothing
            }
            else
            {
                clonedNode = new Node(node.val);
                this.kv.Add(node, clonedNode);

                var clonedNeighbors = node.neighbors.Select(n => this.CloneGraph(n));
                clonedNode.neighbors = clonedNeighbors.ToList();
            }

            return clonedNode;
        }
    }
}

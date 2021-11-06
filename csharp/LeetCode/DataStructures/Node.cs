namespace LeetCode.DataStructures
{
    using System.Collections.Generic;

    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            this.val = 0;
            this.neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            this.val = _val;
            this.neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            this.val = _val;
            this.neighbors = _neighbors;
        }
    }
}

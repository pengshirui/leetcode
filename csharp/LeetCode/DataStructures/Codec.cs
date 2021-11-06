namespace LeetCode.DataStructures
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Codec
    {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            var list = new List<string>();
            while (q.Any())
            {
                var current = q.Dequeue();
                var val = GetString(current);
                list.Add(val);
                if (current != null)
                {
                    q.Enqueue(current.left);
                    q.Enqueue(current.right);
                }
            }
            var sb = new StringBuilder();
            sb.Append(list.First());
            for (var i = 1; i < list.Count; i++)
            {
                sb.Append($",{list[i]}");
            }
            return sb.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            var nodes = data.Split(',');
            var q = new Queue<TreeNode>();
            TreeNode root = null;
            if (nodes.Any())
            {
                root = GetNode(nodes.First());
                if (root != null)
                {
                    q.Enqueue(root);
                }
            }
            var i = 1;
            while (i < nodes.Length && q.Any())
            {
                var current = q.Dequeue();
                if (current != null)
                {
                    if (i < nodes.Length)
                    {
                        var left = GetNode(nodes[i++]);
                        current.left = left;
                        q.Enqueue(left);
                    }
                    if (i < nodes.Length)
                    {
                        var right = GetNode(nodes[i++]);
                        current.right = right;
                        q.Enqueue(right);
                    }
                }
            }
            return root;
        }

        private TreeNode GetNode(string s)
        {
            if (int.TryParse(s, out var val))
            {
                return new TreeNode(val);
            }
            else
            {
                return null;
            }
        }

        private string GetString(TreeNode n)
        {
            return n == null ? "#" : n.val.ToString();
        }
    }
}

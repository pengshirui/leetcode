namespace LeetCode.DataStructures
{
    using System.Collections.Generic;
    using System.Linq;

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static TreeNode GetTreeNode(params int?[] list)
        {
            var queue = new Queue<TreeNode>();
            if (list?.Length == 0)
            {
                return null;
            }
            TreeNode result = null;
            if (list[0] is int root)
            {
                result = new TreeNode(root);
                queue.Enqueue(result);
            }
            var i = 1;
            while (i < list.Length && queue.Any())
            {
                var tempNode = queue.Dequeue();
                if (i < list.Length && list[i++] is int x)
                {
                    var left = new TreeNode(x);
                    tempNode.left = left;
                    queue.Enqueue(left);
                }
                if (i < list.Length && list[i++] is int y)
                {
                    var right = new TreeNode(y);
                    tempNode.right = right;
                    queue.Enqueue(right);
                }

            }

            return result;
        }
    }
}

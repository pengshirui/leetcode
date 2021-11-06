namespace LeetCode.Medium
{
    using System.Collections.Generic;
    using System.Linq;
    using LeetCode.DataStructures;

    public partial class Solution
    {
        public TreeNode TreeToDoublyList(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            var stack = new Stack<TreeNode>();
            var head = new TreeNode();
            var cur = head;
            TreeNode lastNode = null;
            while (root != null || stack.Any())
            {
                while (root != null)
                {
                    stack.Push((TreeNode)root);
                    root = root.left;
                }
                root = stack.Pop();
                lastNode = root;
                cur.right = root;
                root.left = cur;
                cur = root;
                root = root.right;
            }
            head.right.left = lastNode;
            lastNode.right = head.right;
            return head.right;
        }
    }
}

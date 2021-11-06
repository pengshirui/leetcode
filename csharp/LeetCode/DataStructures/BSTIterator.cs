namespace LeetCode.DataStructures
{
    using System.Collections.Generic;
    using System.Linq;

    public class BSTIterator
    {
        private readonly Stack<TreeNode> Stack;
        public BSTIterator(TreeNode root)
        {
            Stack = new Stack<TreeNode> ();
            while (root != null)
            {
                Stack.Push(root);
                root = root.left;
            }
        }

        public int Next()
        {
            if (HasNext())
            {
                var current = Stack.Pop();
                var right = current.right;
                while (right != null)
                {
                    Stack.Push(right);
                    right = right.left;
                }
                return current.val;
            }
            return -1;
        }

        public bool HasNext()
        {
            return Stack.Any();
        }
    }
}

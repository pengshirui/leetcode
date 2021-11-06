namespace LeetCode.Easy
{
    using System.Collections.Generic;
    using System.Linq;
    using LeetCode.DataStructures;

    public partial class Solution
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var ans = new List<int>();
            Preorder(root, ans);
            return ans;
        }

        void Preorder(TreeNode root, IList<int> ans)
        {
            if (root == null)
            {
                return;
            }
            ans.Add(root.val);
            Preorder(root.left, ans);
            Preorder(root.right, ans);
        }

        public IList<int> PreorderTraversal2(TreeNode root)
        {
            var ans = new List<int>();
            var stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Any())
            {
                var node = stack.Pop();
                if (node != null)
                {
                    ans.Add(node.val);
                    stack.Push(node.right);
                    stack.Push(node.left);
                }
            }
            return ans;
        }
    }
}

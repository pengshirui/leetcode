namespace LeetCode.Medium
{
    using System.Collections.Generic;
    using LeetCode.DataStructures;

    public partial class Solution
    {
        public void Flatten(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            var list = new List<TreeNode>();
            this.InOrderTraverse(root, list);
            TreeNode prev = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                prev.left = null;
                prev.right = list[i];
                prev = list[i];
            }
        }

        void InOrderTraverse(TreeNode root, IList<TreeNode> list)
        {
            if (root == null)
            {
                return;
            }
            list.Add(root);
            this.InOrderTraverse(root.left, list);
            this.InOrderTraverse(root.right, list);
        }
    }
}

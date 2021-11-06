namespace LeetCode.Medium.DelNodes
{
    using System.Collections.Generic;
    using LeetCode.DataStructures;

    public class Solution
    {
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            if (to_delete == null || to_delete.Length == 0) return new List<TreeNode> { root };
            var set = new HashSet<int>(to_delete);
            var res = new List<TreeNode>();

            Del(res, null, root, set);
            return res;
        }

        void Del(IList<TreeNode> res, TreeNode parent, TreeNode node, HashSet<int> set)
        {
            if (node == null) return;
            if (parent == null && !set.Contains(node.val))
            {
                res.Add(node);
            }
            else if (set.Contains(node.val))
            {
                if (parent.left?.val == node.val)
                {
                    parent.left = null;
                }
                else
                {
                    parent.right = null;
                }
            }

            parent = set.Contains(node.val) ? null : node;
            Del(res, parent, node.left, set);
            Del(res, parent, node.right, set);
        }
    }
}

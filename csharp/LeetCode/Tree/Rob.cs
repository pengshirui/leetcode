namespace LeetCode.Tree.Rob
{
    using LeetCode.DataStructures;
    using System;

    public class Solution
    {
        public int Rob(TreeNode root)
        {
            var (x, y) = RobInternal(root);
            return Math.Max(x, y);
        }

        // take current, skip current
        (int, int) RobInternal(TreeNode root)
        {
            if (root == null)
            {
                return (0, 0);
            }
            var (l1, l0) = RobInternal(root.left);
            var (r1, r0) = RobInternal(root.right);

            var c1 = l0 + r0 + root.val;
            var c0 = Math.Max(l1, l0) + Math.Max(r1, r0);
            return (c1, c0);

        }
    }
}

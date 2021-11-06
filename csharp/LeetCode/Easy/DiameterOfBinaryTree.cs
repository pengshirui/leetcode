namespace LeetCode.Easy.DiameterOfBinaryTree
{
    using System;
    using LeetCode.DataStructures;
    public class Solution
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            return Diameter(root).Item1;
        }

        // maxLength, lengthToRoot
        (int, int) Diameter(TreeNode root)
        {
            if (root == null) return (0, 0);
            var (maxLeft, leftToRoot) = Diameter(root.left);
            var (maxRight, rightToRoot) = Diameter(root.right);
            var max = Math.Max(maxLeft, maxRight);
            max = Math.Max(max, leftToRoot + rightToRoot);
            var maxToRoot = Math.Max(leftToRoot, rightToRoot) + 1;
            return (max, maxToRoot);
        }
    }
}

namespace LeetCode.Medium.LongestConsecutive
{
    using System;
    using LeetCode.DataStructures;

    public class Solution
    {
        public int LongestConsecutive(TreeNode root)
        {
            if (root == null) return 0;
            return Longest(root, null).Item1;
        }

        // Longest, currentToRoot
        (int, int) Longest(TreeNode root, int? val)
        {
            if (root == null) return (0, 1);
            var (l, ltoRoot) = Longest(root.left, root.val);
            var (r, rToRoot) = Longest(root.right, root.val);
            var toRoot = Math.Max(ltoRoot, rToRoot);
            if (val != null && val + 1 == root.val)
            {
                toRoot++;
            }
            else
            {
                toRoot = 1;
            }
            var result = Math.Max(l, r);
            result = Math.Max(result, toRoot);
            return (result, toRoot);
        }
    }
}

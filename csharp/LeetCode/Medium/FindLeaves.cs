namespace LeetCode.Medium.FindLeaves
{
    using System;
    using System.Collections.Generic;
    using LeetCode.DataStructures;

    public class Solution
    {
        public IList<IList<int>> FindLeaves(TreeNode root)
        {
            var result = new List<IList<int>>();
            GetHeight(root, result);
            return result;
        }

        int GetHeight(TreeNode root, IList<IList<int>> result)
        {
            if (root == null) return -1;
            var left = GetHeight(root.left, result);
            var right = GetHeight(root.right, result);
            var currentHeight = Math.Max(left, right) + 1;
            if (currentHeight == result.Count)
            {
                result.Add(new List<int>());
            }
            result[currentHeight].Add(root.val);
            return currentHeight;
        }
    }
}

using System;
using LeetCode.DataStructures;

namespace LeetCode.Hard
{
    public partial class Solution
    {
        public int MaxPathSum(TreeNode root)
        {
            return this.MaxPathSumInternal1(root).Item2;
        }

        /// <summary>
        /// MaxPathSumInternal
        /// </summary>
        /// <param name="root"></param>
        /// <returns>(SumToRoot, SumFromSubTree)</returns>
        (int, int) MaxPathSumInternal1(TreeNode root)
        {
            if (root == null)
            {
                return (0, int.MinValue);
            }
            var (leftToRoot, maxSumFromLeft) = this.MaxPathSumInternal1(root.left);
            var (rightToRoot, maxSumFromRight) = this.MaxPathSumInternal1(root.right);

            var leftPath = Math.Max(leftToRoot, 0);
            var rightPath = Math.Max(rightToRoot, 0);
            var sumToRoot = root.val + Math.Max(leftPath, rightPath);
            var sumPassRoot = leftPath + rightPath + root.val;

            var maxSum = Math.Max(maxSumFromLeft, maxSumFromRight);
            maxSum = Math.Max(maxSum, sumPassRoot);
            return (sumToRoot, maxSum);
        }
    }
}

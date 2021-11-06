using LeetCode.DataStructures;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            return this.IsValidBST(root, null, null);
        }

        bool IsValidBST(TreeNode root, int? lowerBound, int? upperBound)
        {
            if (root == null)
            {
                return true;
            }
            if (root.val <= lowerBound || root.val >= upperBound)
            {
                return false;
            }
            return this.IsValidBST(root.left, lowerBound, root.val) && this.IsValidBST(root.right, root.val, upperBound);
        }
    }
}

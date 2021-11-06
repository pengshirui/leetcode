namespace LeetCode.Medium
{
    using LeetCode.DataStructures;

    public partial class Solution
    {
        public int CountNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return CountNodes(root.left) + CountNodes(root.right) + 1;
        }
    }
}

namespace LeetCode.Easy.RangeSumBST
{
    using LeetCode.DataStructures;

    public class Solution
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            var result = root.val >= low && root.val <= high ? root.val : 0;
            if (root.left != null && root.val >= low)
            {
                result += RangeSumBST(root.left, low, high);
            }
            if (root.right != null && root.val <= high)
            {
                result += RangeSumBST(root.right, low, high);
            }
            return result;
        }
    }
}

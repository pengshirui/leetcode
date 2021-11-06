namespace LeetCode.Medium.GoodNodes
{
    using LeetCode.DataStructures;

    public class Solution
    {
        public int GoodNodes(TreeNode root)
        {
            return GoodNodes(root, root.val);
        }

        int GoodNodes(TreeNode root, int rootVal)
        {
            if (root == null) return 0;
            var result = 0;
            if (root.val >= rootVal)
            {
                result++;
                rootVal = root.val;
            }

            result += GoodNodes(root.left, rootVal);
            result += GoodNodes(root.right, rootVal);
            return result;

        }
    }
}

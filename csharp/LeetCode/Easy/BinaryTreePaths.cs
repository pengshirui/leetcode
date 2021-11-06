using System.Collections.Generic;
using LeetCode.DataStructures;

namespace LeetCode.Easy
{
    public partial class Solution
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            var result = new List<string>();
            this.BinaryTreePathsInternal(root, string.Empty, result);
            return result;
        }

        void BinaryTreePathsInternal(TreeNode root, string path, IList<string> result)
        {
            if (root == null)
            {
                return;
            }
            if (path == string.Empty)
            {
                path = $"{root.val}";
            }
            else
            {
                path += $"->{root.val}";
            }
            if (root.left == null && root.right == null)
            {
                result.Add(path);
            }


            this.BinaryTreePathsInternal(root.left, path, result);
            this.BinaryTreePathsInternal(root.right, path, result);
        }
    }
}

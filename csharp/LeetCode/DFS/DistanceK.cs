namespace LeetCode.DFS.DistanceK
{
    using System.Collections.Generic;
    using LeetCode.DataStructures;

    public class Solution
    {
        TreeNode R;
        TreeNode T;
        int K;
        IList<int> Result = new List<int>();
        public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
        {
            R = root;
            T = target;
            K = k;
            if (k == 0)
            {
                Result.Add(target.val);
            }
            else
            {
                DFS(root, 0);
            }
            return Result;
        }

        int DFS(TreeNode root, int d)
        {
            if (root == null) return 0;
            if (d == K)
            {
                Result.Add(root.val);
                return 0;
            }
            if (root.val == T.val || d > 0)
            {
                // found target
                // The caller node distance to target
                DFS(root.left, d + 1);
                DFS(root.right, d + 1);
                return 1;
            }

            // keep searching
            var l = DFS(root.left, 0);
            if (l == K)
            {
                Result.Add(root.val);
                return 0;
            }
            if (l > 0)
            {
                // research right
                DFS(root.right, l + 1);
                return l + 1;
            }

            var r = DFS(root.right, 0);
            if (r == K)
            {
                Result.Add(root.val);
                return 0;
            }
            if (r > 0)
            {
                // research right
                DFS(root.left, r + 1);
                return r + 1;
            }
            return 0;
        }
    }
}

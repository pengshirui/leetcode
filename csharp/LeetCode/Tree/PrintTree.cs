namespace LeetCode.Tree.PrintTree
{
    using LeetCode.DataStructures;
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        string[][] res;
        int h, m, n, c;
        public IList<IList<string>> PrintTree(TreeNode root)
        {
            h = GetHeight(root);
            m = h + 1;
            if (h < 0) return new string[0][];
            n = (int)(Math.Pow(2, h + 1) - 1);
            c = (n - 1) / 2;
            res = new string[m][];


            for (var i = 0; i < m; i++)
            {
                var str = new string[n];
                res[i] = str;
                Array.Fill(str, "");
            }

            DFS(0, c, root);
            return res;
        }

        void DFS(int i, int j, TreeNode node)
        {
            if (node == null) return;

            res[i][j] += node.val;
            DFS(i + 1, (int)(j - Math.Pow(2, h - i - 1)), node.left);
            DFS(i + 1, (int)(j + Math.Pow(2, h - i - 1)), node.right);
        }

        int GetHeight(TreeNode root)
        {
            if (root == null) return -1;
            return Math.Max(GetHeight(root.left), GetHeight(root.right)) + 1;
        }

    }
}

namespace LeetCode.Hard.ClosestKValues
{
    using System;
    using System.Collections.Generic;
    using LeetCode.DataStructures;

    public class Solution
    {
        public IList<int> ClosestKValues(TreeNode root, double target, int k)
        {
            var values = new List<int>();
            Inorder(root, values);

            var win_start = 0; // start window from 0 to k-1

            for (int i = k; i < values.Count; i++)
            {
                double diff1 = Math.Abs(target - (double)values[i]);
                double diff2 = Math.Abs(target - (double)values[win_start]);
                if (diff1 < diff2) win_start++;
            }
            return values.GetRange(win_start, k);
        }

        void Inorder(TreeNode root, IList<int> values)
        {
            if (root == null) return;
            Inorder(root.left, values);
            values.Add(root.val);
            Inorder(root.right, values);
        }
    }
}

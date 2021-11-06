namespace LeetCode.Medium
{
    using System.Collections.Generic;
    using System.Linq;
    using LeetCode.DataStructures;

    public partial class Solution
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var ans = new List<IList<int>>();
            var q = new Queue<TreeNode>();
            if (root == null)
            {
                return ans;
            }
            q.Enqueue(root);
            var isLeftToRight = true;
            while (q.Any())
            {
                var count = q.Count;
                var level = new List<int>();
                while (count > 0)
                {
                    var node = q.Dequeue();
                    if (isLeftToRight)
                    {
                        level.Add(node.val);
                    }
                    else
                    {
                        level.Insert(0, node.val);
                    }
                    if (node.right != null)
                        q.Enqueue(node.right);
                    if (node.left != null)
                        q.Enqueue(node.left);

                    count--;
                }
                ans.Add(level);

                isLeftToRight = !isLeftToRight;
            }

            return ans;
        }
    }
}

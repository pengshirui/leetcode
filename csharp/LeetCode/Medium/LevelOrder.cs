namespace LeetCode.Medium
{
    using System.Collections.Generic;
    using System.Linq;
    using LeetCode.DataStructures;

    public partial class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var ans = new List<IList<int>>();
            var q = new Queue<TreeNode>();
            if (root == null)
            {
                return ans;
            }
            q.Enqueue(root);
            while (q.Any())
            {
                var count = q.Count;
                var level = new List<int>();
                while (count > 0)
                {
                    var node = q.Dequeue();
                    level.Add(node.val);
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                    count--;
                }
                ans.Add(level);
            }

            return ans;
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using LeetCode.DataStructures;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
            {
                return result;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                var count = queue.Count;
                while (count > 0)
                {
                    var cur = queue.Dequeue();
                    if (cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }

                    if (cur.right != null)
                    {
                        queue.Enqueue(cur.right);
                    }
                    count--;

                    if (count == 0)
                    {
                        result.Add(cur.val);
                    }
                }
            }

            return result;
        }
    }
}

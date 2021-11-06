namespace LeetCode.Medium
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LeetCode.DataStructures;

    public partial class Solution
    {
        public IList<IList<int>> VerticalOrder(TreeNode root)
        {
            var queue = new Queue<TreeNodePlus>();

            var current = root;
            if (current != null)
            {
                queue.Enqueue(new TreeNodePlus(current, 0));
            }
            var posToList = new SortedDictionary<int, IList<int>>();
            while (queue.Any())
            {
                var count = queue.Count;
                while (count > 0)
                {
                    var treeNodePlus = queue.Dequeue();
                    current = treeNodePlus.node;
                    if (posToList.TryGetValue(treeNodePlus.vlevel, out var list))
                    {
                        list.Add(current.val);
                    }
                    else
                    {
                        posToList[treeNodePlus.vlevel] = new List<int> { current.val };
                    }
                    if (current.left != null)
                    {
                        queue.Enqueue(new TreeNodePlus(current.left, treeNodePlus.vlevel - 1));
                    }
                    if (current.right != null)
                    {
                        queue.Enqueue(new TreeNodePlus(current.right, treeNodePlus.vlevel + 1));
                    }
                    count--;
                }
            }

            var res = new List<IList<int>>();
            foreach (var list in posToList.Values)
            {
                res.Add(list);
            }
            return res;
        }
    }

    public class TreeNodePlus
    {
        public TreeNode node;
        public int vlevel;
        public TreeNodePlus(TreeNode node, int vlevel)
        {
            this.node = node;
            this.vlevel = vlevel;
        }
    }
}

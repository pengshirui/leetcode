namespace LeetCode.Easy
{
    using System.Collections.Generic;
    using System.Linq;
    using LeetCode.DataStructures;

    public partial class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            var stack = new Stack<TreeNode>();
            var curr = root;

            while (curr != null || stack.Any())
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                result.Add(curr.val);
                curr = curr.right;
            }
            return result;
        }
    }
}

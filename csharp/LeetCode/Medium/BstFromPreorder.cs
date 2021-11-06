namespace LeetCode.Medium.BstFromPreorder
{
    using System.Collections.Generic;
    using System.Linq;
    using LeetCode.DataStructures;

    public class Solution
    {
        public TreeNode BstFromPreorder(int[] preorder)
        {
            var stack = new Stack<TreeNode>();
            var root = new TreeNode(preorder[0]);
            stack.Push(root);
            for (var i = 1; i < preorder.Length; i++)
            {
                var n = preorder[i];
                if (stack.Peek().val > n)
                {
                    var peek = stack.Peek();
                    var newNode = new TreeNode(n);
                    peek.left = newNode;
                    stack.Push(newNode);
                }
                else
                {
                    TreeNode lastPop = null;
                    while (stack.Any() && stack.Peek().val < n)
                    {
                        lastPop = stack.Pop();
                    }

                    var newNode = new TreeNode(n);
                    lastPop.right = newNode;
                    stack.Push(newNode);
                }
            }
            return root;
        }
    }
}

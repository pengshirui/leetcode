package medium;

import common.TreeNode;

// https://leetcode.com/problems/symmetric-tree/
public class IsSymmetric {
  public boolean isSymmetric(TreeNode root) {
    return root == null || helper(root.left, root.right);
  }

  private boolean helper(TreeNode left, TreeNode right) {
    if (left == null || right == null) {
      return left == right;
    }
    return left.val == right.val && helper(left.right, right.left) && helper(left.left, right.right);
  }
}
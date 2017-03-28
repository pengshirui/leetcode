package easy;

import java.util.ArrayDeque;

import common.TreeNode;

public class InvertTree {
    /* Recursive
    public TreeNode invertTree(TreeNode root) {

        root.left = invertTree(root.right);
        root.right = invertTree(root.left);

        return root;
    }
    */

  // DFS
  public TreeNode invertTree(TreeNode root) {
    if (root == null) return root;
    ArrayDeque<TreeNode> arrayDeque = new ArrayDeque<>();
    arrayDeque.push(root);
    while (!arrayDeque.isEmpty()) {
      TreeNode cur = arrayDeque.pop();
      TreeNode tmp = cur.left;
      cur.left = cur.right;
      cur.right = tmp;

      if (cur.left != null) {
        arrayDeque.push(cur.left);
      }
      if (cur.right != null) {
        arrayDeque.push(cur.right);
      }
    }
    return root;
  }

}

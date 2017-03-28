package hard;

import common.TreeNode;
import easy.LowestCommonAncestor;

public class FindDistance {
  public int findDistance(TreeNode root, TreeNode p, TreeNode q) {
    if (root == null || p == q) return 0;
    TreeNode lca = new LowestCommonAncestor().lowestCommonAncestor(root, p, q);
    int l = getLevel(lca, p, 0);
    int r = getLevel(lca, q, 0);
    return l + r;
  }

  private int getLevel(TreeNode root, TreeNode n, int level) {
    if (root == null)
      return 0;

    if (root == n)
      return level;

    int downlevel = getLevel(root.left, n, level + 1);
    if (downlevel != 0) return downlevel;

    downlevel = getLevel(root.right, n, level + 1);
    return downlevel;
  }


}

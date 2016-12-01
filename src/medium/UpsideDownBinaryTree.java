package medium;

import common.TreeNode;

/**
 * Created by shirui on 11/11/16.
 */
public class UpsideDownBinaryTree {
    public TreeNode upsideDownBinaryTree(TreeNode root) {
        if (root == null || (root.left == null && root.right == null)) return root;
        TreeNode newRoot = upsideDownBinaryTree(root.left);
        root.left.left = root.right;
        // cannot use newRoot.right, it will be overwritten
        root.left.right = root;

        root.left = null;
        root.right = null;
        return newRoot;
    }
}

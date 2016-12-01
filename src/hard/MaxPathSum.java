package hard;


import common.TreeNode;

public class MaxPathSum {
    private int maxSum;
    public int maxPathSum(TreeNode root) {
        maxSum = Integer.MIN_VALUE;
        helper(root);
        return maxSum;
    }

    private int helper(TreeNode root) {
        if (root == null) return 0;
        int left = Math.max(helper(root.left), 0);
        int right = Math.max(helper(root.right), 0);
        // set max val is max left + max right + mid vs. last max
        maxSum = Math.max(maxSum, root.val + left + right);
        // return path to root
        return root.val + Math.max(left, right);
    }
}

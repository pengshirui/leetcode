package medium;

import common.TreeNode;

public class ClosestValue {
  public int closestValue(TreeNode root, double target) {
    if (root == null) {
      return 0;
    }
    int result = 0;
    double diff = Integer.MAX_VALUE;
    TreeNode cur = root;
    while (cur != null) {
      double newDiff = Math.abs(target - cur.val);
      if (newDiff < diff) {
        result = cur.val;
        diff = newDiff;
      }
      if (target == cur.val) {
        // return
        return cur.val;
      } else {
        cur = cur.val < target ? cur.right : cur.left;
      }
    }
    return result;
  }

  public int[] removeDups(int[] input) {
    // empty check
    if (input == null || input.length < 2) {
      return input;
    }
    int i = 1;
    // for(int j = 0; ...) { input[0]..input[1].....input[input.length-1] }
    for (int n : input) {
      if (n > input[i - 1]) {
        input[i++] = n;
      }
    }
    // i now equals to the number of the unqiue items;
    // a sorted array with unique items in the front, and some other item after index i; out put in second example.

    int[] output = new int[i];
    System.arraycopy(input, 0, output, 0, i);

    return output;
  }
}

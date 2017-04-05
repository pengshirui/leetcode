package medium;

import common.TreeNode;

import java.util.ArrayList;
import java.util.List;

public class GetHeight {
    public List<List<Integer>> findLeaves(TreeNode root) {
        List<List<Integer>> result = new ArrayList<>();
        getHeight(root, result);
        return result;
    }

    private int getHeight(TreeNode root, List<List<Integer>> result) {
        if (root == null) return -1;
        int height = Math.max(getHeight(root.left, result), getHeight(root.right, result)) + 1;
        if (result.size() <= height) {
            List<Integer> list = new ArrayList<>();
            list.add(root.val);
            result.add(list);
        } else {
            result.get(height).add(root.val);
        }
        return height;
    }
}

package medium;

import common.TreeNode;

import java.util.PriorityQueue;

public class KthSmallest {
    public int kthSmallest(TreeNode root, int k) {
        if (root == null) {
            return 0;
        }
        int leftCount = countNode(root.left);
        if (k <= leftCount) {
            return kthSmallest(root.left, k);
        } else if (k > leftCount + 1) {
            return kthSmallest(root.right, k - leftCount - 1);
        }
        return root.val;
    }

    private int countNode(TreeNode node) {
        if (node == null) {
            return 0;
        }
        return countNode(node.left) + countNode(node.right) + 1;
    }

    public int kthSmallestI(int[][] matrix, int k) {
        int n = matrix.length;
        int lo = matrix[0][0], hi = matrix[n - 1][n - 1];
        while (lo <= hi) {
            int mid = lo + (hi - lo) / 2;
            int count = getLessEqualI(matrix, mid);
            if (count < k) lo = mid + 1;
            else hi = mid - 1;
        }
        return lo;
    }

    public int getLessEqualI(int[][] matrix, int val) {
        int res = 0;
        int n = matrix.length, i = n - 1, j = 0;
        while (i >= 0 && j < n) {
            if (matrix[i][j] > val) i--;
            else {
                res += i + 1;
                j++;
            }
        }
        return res;
    }

    public int getLessEqualII(int[][] matrix, int val) {
        int count = 0;
        int row = 0, col = matrix.length - 1;
        while (row < matrix.length && col >= 0) {
            if (matrix[row][col] > val) {
                col--;
            } else {
                row++;
                count += col + 1;
            }
        }
        return count;
    }

    public int kthSmallestII(int[][] matrix, int k) {
        if (matrix == null || matrix.length == 0 || matrix[0].length == 0) return 0;
        PriorityQueue<Tuple> heap = new PriorityQueue<>();
        // insert the first row
        int bound = matrix.length < k ? matrix.length : k;
        for (int i = 0; i < bound; i++) {
            heap.offer(new Tuple(0, i, matrix[0][i]));
        }
        while (k > 1) {
            Tuple t = heap.poll();
            k--;
            // skip if it is the last row
            if (t.row == matrix.length - 1) continue;
            heap.offer(new Tuple(t.row + 1, t.col, matrix[t.row + 1][t.col]));

        }
        return heap.poll().val;
    }


    private class Tuple implements Comparable<Tuple> {
        int val;
        int row, col;

        public Tuple(int row, int col, int val) {
            this.row = row;
            this.col = col;
            this.val = val;
        }

        // min
        @Override
        public int compareTo(Tuple o) {
            return this.val - o.val;
        }
    }
}

package medium;

public class Multiply {
    public int[][] multiply(int[][] A, int[][] B) {
        int rows = A.length;
        int cols = B[0].length;
        int rc = B.length; // shared rows and cols
        int [][] res = new int[rows][cols];

        for (int i = 0; i < rows; i++) {
            for (int k = 0; k < rc; k++) {
                // loop A from left to right, top to bot
                // skip 0
                if (A[i][k] != 0) {
                    for (int j = 0; j < cols; j++) {
                        // loop B from top to bot, lef to right
                        if (B[k][j] != 0) res[i][j] += A[i][k] * B[k][j];
                    }
                }
            }
        }
        return res;
    }
}

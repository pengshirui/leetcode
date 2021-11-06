package medium;

import java.util.Arrays;

public class NumSquares {
    public int numSquares(int n) {
        int[] memo = new int[n + 1];
        Arrays.fill(memo, Integer.MAX_VALUE);
        memo[0] = 0;
        for (int i = 0; i <= n; i++) {
            for (int j = 1; i + j * j <= n; j++) {
                // set 1,4,9 -> 1
                // set 2,5,10 -> 2
                memo[i + j * j] = Math.min(memo[i] + 1, memo[i + j * j]);
            }
        }
        return memo[n];
    }
}

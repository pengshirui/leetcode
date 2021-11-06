package dp;

import java.util.Arrays;

public class DP898 {
    public Integer dp898(Integer n, Integer[][] arrays) {

        var dp = new Integer[n];
        Arrays.fill(dp, Integer.MIN_VALUE);
        var res = Integer.MIN_VALUE;
        for (var array : arrays) {
            var temp = dp;
            for (var i = 0; i < array.length; i++) {
                var left = i == 0 ? Integer.MIN_VALUE : temp[i - 1];
                var right = temp[i];
                dp[i] = Math.max(left, right) + array[i];
                res = Math.max(res, dp[i]);
            }
        }
        return res;
    }
}

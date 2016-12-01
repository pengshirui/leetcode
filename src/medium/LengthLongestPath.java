package medium;

import java.util.ArrayDeque;

public class LengthLongestPath {
    public int lengthLongestPath(String input) {
        // null check
        if (input == null || input.length() == 0) {
            return 0;
        }
        // tokenize
        String[] paths = input.split("\n");
        int[] stack = new int[paths.length + 1];
        int maxLen = 0;
        for (String path : paths) {
            int lev = path.lastIndexOf("\t") + 1,
            // current total length = the pre level length + current level length - level + trailing slash
            curLen = stack[lev + 1] = stack[lev] + path.length() - lev + 1;
            if (path.contains(".")) {
                maxLen = Math.max(maxLen, curLen - 1);
            }
        }
        return maxLen;
    }
}

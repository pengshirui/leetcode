package medium;

import java.util.Set;

public class WordBreak {
    public boolean wordBreak(String s, Set<String> wordDict) {
        if (s == null || s.length() == 0 || wordDict.size() == 0) {
            return false;
        }
        boolean[] memo = new boolean[s.length() + 1];
        memo[0] = true;
        // i is NOT the index of the string, it is the number count of the string
        // it then is the memo index, and end position of substring method
        for (int i = 1; i <= s.length(); i++) {
            // j is the index of the string
            for (int j = i - 1; j >= 0; j--) {
                // if p1: 0 -> j - 1 is true
                // p1 is store in memo[j]
                // then check p2: j -> i
                if (memo[j] && wordDict.contains(s.substring(j, i))) {
                    memo[i] = true;
                    break;
                }
            }
        }
        return memo[s.length()];
    }
}

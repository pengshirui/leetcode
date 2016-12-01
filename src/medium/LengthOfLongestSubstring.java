package medium;

import java.util.HashMap;

public class LengthOfLongestSubstring {
    public int lengthOfLongestSubstring(String s) {
        if (s == null || s.length() == 0) {
            return 0;
        }
        HashMap<Character, Integer> hm = new HashMap<>();
        int max = 0;
        for (int start = 0, end = 0; start < s.length() && end < s.length(); end++) {
            if (hm.containsKey(s.charAt(end))) {
                start = Math.max(start, hm.get(s.charAt(end)) + 1);
            }
            hm.put(s.charAt(end), end);
            max = Math.max(max, end - start + 1);
        }
        return max;
    }
}

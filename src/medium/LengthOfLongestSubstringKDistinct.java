package medium;

import java.util.HashMap;

public class LengthOfLongestSubstringKDistinct {
  public int lengthOfLongestSubstringKDistinct(String s, int k) {
    if (s == null || s.length() == 0 || k == 0) {
      return 0;
    }
    // length is smaller than not equal k
    if (s.length() <= k) {
      return s.length();
    }
    HashMap<Character, Integer> hashMap = new HashMap<>();
    int start = 0;
    int max = k;
    for (int i = 0; i < s.length(); i++) {
      char c = s.charAt(i);
      if (hashMap.containsKey(c)) {
        hashMap.put(c, hashMap.get(c) + 1);
      } else {
        hashMap.put(c, 1);
      }

      if (hashMap.size() > k) {
        max = Math.max(max, i - start);
        while (hashMap.size() > k) {
          char head = s.charAt(start);
          int count = hashMap.get(head);
          if (count > 1) {
            hashMap.put(head, count - 1);
          } else {
            hashMap.remove(head);
          }
          start++;
        }
      }
    }
    max = Math.max(max, s.length() - start);
    return max;
  }
}

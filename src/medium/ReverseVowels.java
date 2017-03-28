package medium;

import java.util.HashSet;

public class ReverseVowels {
  public String reverseVowels(String s) {
    if (s == null || s.length() < 2) {
      return s;
    }
    int l = 0;
    int r = s.length() - 1;
    HashSet<Character> hs = new HashSet<>();
    initHashSet(hs);
    char[] charArr = s.toCharArray();
    while (l < r) {
      while (l < charArr.length && !isVowel(charArr[l], hs)) {
        l++;
      }
      while (r >= 0 && !isVowel(charArr[r], hs)) {
        r--;
      }
      if (l < r) {
        char tmp = charArr[r];
        charArr[r] = charArr[l];
        charArr[l] = tmp;
        l++;
        r--;
      }
    }
    return new String(charArr);
  }

  private boolean isVowel(char c, HashSet<Character> hs) {
    return hs.contains(Character.toLowerCase(c));
  }

  private void initHashSet(HashSet<Character> hs) {
    hs.add('a');
    hs.add('e');
    hs.add('i');
    hs.add('o');
    hs.add('u');
  }

}

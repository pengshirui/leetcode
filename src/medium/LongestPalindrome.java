package medium;

public class LongestPalindrome {
  public String longestPalindrome(String s) {
    if (s == null || s.length() < 2) {
      return s;
    }
    int start = 0, end = 0;
    for (int i = 0; i < s.length(); i++) {
      int rs1 = expandAroundCenter(s, i, i);
      int rs2 = expandAroundCenter(s, i, i + 1);
      int rs = Math.max(rs1, rs2);
      if (rs > end - start) {
        end = i + rs / 2;
        start = i - (rs - 1) / 2;
      }
    }
    return s.substring(start, end + 1);
  }

  // return left and right index of the max palindromic string
  private int expandAroundCenter(String s, int l, int r) {
    while (l >= 0 && r < s.length() && s.charAt(l) == s.charAt(r)) {
      l--;
      r++;
    }
    return r - l - 1;
  }
}

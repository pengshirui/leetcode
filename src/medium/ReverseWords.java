package medium;

public class ReverseWords {
    public void reverseWords(char[] s) {
        if (s == null || s.length < 2) {
            return;
        }
        // reverse the entire string
        reverse(s, 0, s.length - 1);
        // reverse only the word
        int last = 0;
        for (int i = 0; i < s.length; i++) {
            if (s[i] == ' ') {
                reverse(s, last, i - 1);
                last = i + 1;
            }
        }
        reverse(s, last, s.length - 1);
    }

    private void reverse(char[] s, int start, int end) {
        while (start < end) {
            char t = s[start];
            s[start] = s[end];
            s[end] = t;
            start++;
            end--;
        }
    }
}

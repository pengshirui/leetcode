package easy;

import java.util.ArrayDeque;
import java.util.Deque;

/**
 * Created by yizhu on 1/14/17.
 */
public class IsValid {

  public boolean isValid(String s) {
    if (s == null || s.length() == 0) {
      return false;
    } else {
      Deque<Character> stack = new ArrayDeque<>(s.length());
      for (int i = 0; i < s.length(); i++) {
        if (s.charAt(i) == '(' || s.charAt(i) == '{' || s.charAt(i) == '[') {
          stack.push(s.charAt(i));
        } else if (!stack.isEmpty()) {
          char out = stack.pop();
          if (s.charAt(i) == '}' && out != '{') {
            return false;
          } else if (s.charAt(i) == ']' && out != '[') {
            return false;
          } else if (s.charAt(i) == ')' && out != '(') {
            return false;
          }
        } else {
          // character is not one of the left brackets and the stack is empty
          return false;
        }
      }
      return stack.isEmpty();
    }
  }
}

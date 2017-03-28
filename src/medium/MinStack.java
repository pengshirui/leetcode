package medium;

import java.util.Stack;

/**
 * Created by shirui on 10/23/16.
 */
public class MinStack {
  /**
   * initialize your data structure here.
   */
  Stack<Integer> minStack;
  Stack<Integer> stack;

  public MinStack() {
    minStack = new Stack<>();
    stack = new Stack<>();
  }

  public void push(int x) {
    stack.push(x);
    if (getMin() > x) {
      minStack.push(x);
    } else {
      minStack.push(getMin());
    }

  }

  public void pop() {
    minStack.pop();
    stack.pop();
  }

  public int top() {
    return stack.peek();
  }

  public int getMin() {
    return minStack.peek();
  }
}

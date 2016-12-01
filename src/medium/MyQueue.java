package medium;

import java.util.Stack;

class MyQueue {
    // Push element x to the back of queue.
    private Stack<Integer> s1 = new Stack<>();
    private Stack<Integer> s2 = new Stack<>();
    public void push(int x) {
        s1.push(x);
    }

    // Removes the element from in front of queue.
    public void pop() {
        while (s1.size() > 0) {
            s2.push(s1.pop());
        }
        if (s2.size() > 0) {
            s2.pop();
        }
        while (s2.size() > 0) {
            s1.push(s2.pop());
        }
    }

    // Get the front element.
    public int peek() {
        int a = -1;
        while (s1.size() > 0) {
            s2.push(s1.pop());
        }
        if (s2.size() > 0) {
            a = s2.pop();
            s2.push(a);
        }
        while (s2.size() > 0) {
            s1.push(s2.pop());
        }
        return a;
    }

    // Return whether the queue is empty.
    public boolean empty() {
        return s1.isEmpty();
    }
}
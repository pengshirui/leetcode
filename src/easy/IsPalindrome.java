package easy;

import common.ListNode;

public class IsPalindrome {

    public boolean isPalindrome(int x) {
        if (x < 0 || (x != 0 && x % 10 == 0)) {
            return false;
        }

        int rev = 0;
        while (x > rev) {
            // rev * 10 and add the tail of x
            rev = rev * 10 + x % 10;
            x /= 10;
        }
        // even length x = rev, odd length x = rev / 10
        return (x == rev) || (x == rev / 10);
    }

    public boolean isPalindrome(ListNode head) {
        assert head != null : "asdf";
        if (head == null || head.next == null) {
            return true;
        }
        ListNode mid = findMid(head);
        ListNode right = mid.next;
        mid.next = null;
        ListNode reversedRight = reverse(right);
        return compare(head, reversedRight);
    }

    public boolean isPalindrome(String s) {
        if (s == null || s.length() == 0) {
            return true;
        }
        char[] chars = s.toLowerCase().toCharArray();
        int l = 0;
        int r = s.length() - 1;
        while (l < r) {
            while (l < r && !Character.isLetterOrDigit(chars[l])) {
                l++;
            }
            while (l < r && !Character.isLetterOrDigit(chars[r])) {
                r++;
            }
            if (l < r && chars[l] != chars[r]) {
                return false;
            }
        }
        return true;
    }

    private boolean compare(ListNode head, ListNode reversedRight) {
        while (head != null && reversedRight != null) {
            if (head.val != reversedRight.val) {
                return false;
            }
            head = head.next;
            reversedRight = reversedRight.next;
        }
        return true;
    }

    private ListNode reverse(ListNode node) {
        ListNode left = null;
        ListNode cur = node;
        while (cur != null) {
            ListNode right = cur.next;
            cur.next = left;
            left = cur;
            cur = right;
        }
        return left;
    }

    private ListNode findMid(ListNode head) {
        ListNode fast = head.next;
        ListNode slow = head;
        while (fast != null && fast.next != null) {
            fast = fast.next.next;
            slow = slow.next;
        }
        return slow;
    }


}

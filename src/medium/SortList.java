package medium;

import common.ListNode;

public class SortList {
  public ListNode sortList(ListNode head) {
    if (head == null || head.next == null) return head;
    ListNode mid = findMid(head);
    ListNode right = sortList(mid.next);
    // break the mid so the left can be run without infinite
    mid.next = null;
    ListNode left = sortList(head);
    return merge(left, right);
  }

  // find the mid left
  private ListNode findMid(ListNode head) {
    ListNode quick = head.next;
    ListNode slow = head;
    while (quick != null && quick.next != null) {
      quick = quick.next.next;
      slow = slow.next;
    }
    return slow;
  }

  private ListNode merge(ListNode l1, ListNode l2) {
    ListNode dummyHead = new ListNode(0);
    ListNode cur = dummyHead;
    while (l1 != null && l2 != null) {
      if (l1.val < l2.val) {
        cur.next = l1;
        l1 = l1.next;
      } else {
        cur.next = l2;
        l2 = l2.next;
      }
      cur = cur.next;
    }
    cur.next = l1 != null ? l1 : l2;
    return dummyHead.next;
  }
}

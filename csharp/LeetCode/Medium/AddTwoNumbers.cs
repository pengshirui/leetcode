using LeetCode.DataStructures;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var carry = 0;
            var head = new ListNode();
            var cur = head;
            while (l1 != null || l2 != null)
            {
                var v1 = l1 == null ? 0 : l1.val;
                var v2 = l2 == null ? 0 : l2.val;
                var val = carry + v1 + v2;
                var remainder = val % 10;
                carry = val / 10;
                cur.next = new ListNode(remainder);
                cur = cur.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (carry == 1)
            {
                cur.next = new ListNode(1);
            }
            return head.next;
        }

        public ListNode AddTwoNumbersRecursive(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            var sum = (l1?.val ?? 0) + (l2?.val ?? 0);
            var carry = sum / 10;
            var remainder = sum % 10;

            l1 = l1?.next;
            l2 = l2?.next;

            if (carry > 0)
            {
                if (l1 == null)
                {
                    l1 = new ListNode(carry);
                }
                else
                {
                    l1.val += carry;
                }
            }

            return new ListNode(remainder, this.AddTwoNumbersRecursive(l1, l2));
        }
    }
}

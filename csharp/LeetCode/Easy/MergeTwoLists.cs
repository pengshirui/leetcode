using LeetCode.DataStructures;

namespace LeetCode.Easy
{
    public partial class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var dummyHead = new ListNode();
            var current = dummyHead;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                    current = current.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                    current = current.next;
                }
            }

            if (l1 != null)
            {
                current.next = l1;
            }
            if (l2 != null)
            {
                current.next = l2;
            }
            return dummyHead.next;
        }
    }
}

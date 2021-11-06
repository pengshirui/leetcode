namespace LeetCode.Medium
{
    using LeetCode.DataStructures;

    public partial class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var fast = head;
            var slow = head;
            while (n > 0)
            {
                fast = fast.next;
                n--;
            }

            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            var toRemove = slow.next;
            var toLink = toRemove.next;
            slow.next = toLink;

            return head;
        }
    }
}

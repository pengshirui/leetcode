namespace LeetCode.Easy
{
    using LeetCode.DataStructures;

    public partial class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            var cur = head;
            while (cur != null)
            {
                var nextTemp = cur.next;
                cur.next = prev;
                prev = cur;
                cur = nextTemp;
            }
            return prev;
        }
    }

}

namespace LeetCode.Hard
{
    using LeetCode.DataStructures;

    public partial class Solution
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            var ans = new ListNode();
            ans.next = head;
            var start = head;
            var prev = ans;
            while (start != null)
            {
                var end = start;
                var i = 1;
                while (i < k && end != null)
                {
                    end = end.next;
                    i++;
                }
                if (end != null)
                {
                    var endNext = end.next;
                    var (newStart, newEnd) = Reverse(start, end);
                    prev.next = newStart;
                    prev = newEnd;
                    newEnd.next = endNext;
                    start = endNext;
                }
                else
                {
                    start = end;
                }
            }

            return ans.next;

        }

        (ListNode, ListNode) Reverse(ListNode start, ListNode end)
        {
            var newStart = end;
            var newEnd = start;
            var cur = start;
            var endNext = end.next;
            ListNode prev = null;
            while (cur != endNext)
            {
                var next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }

            return (newStart, newEnd);
        }
    }
}

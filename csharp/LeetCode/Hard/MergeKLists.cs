namespace LeetCode.Hard.MergeKLists
{
    using LeetCode.DataStructures;

    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;
            return Merge(lists, 0, lists.Length - 1);
        }

        ListNode Merge(ListNode[] lists, int start, int end)
        {
            if (start == end) return lists[start];
            var m = (start + end) / 2;
            return MergeTwoList(Merge(lists, start, m), Merge(lists, m + 1, end));
        }

        ListNode MergeTwoList(ListNode l1, ListNode l2)
        {
            var res = new ListNode();
            var cur = res;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                cur = cur.next;
            }
            if (l1 != null) cur.next = l1;
            if (l2 != null) cur.next = l2;
            return res.next;
        }
    }
}

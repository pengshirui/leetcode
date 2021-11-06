using LeetCode.DataStructures;
using EasySolution = LeetCode.Easy.Solution;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public void ReorderList(ListNode head)
        {
            // 1. find mid
            var solution = new EasySolution();
            var mid = solution.MiddleNode(head);
            // 2. reverse the last part
            var reversed = solution.ReverseList(mid);
            // 3. merge two list
            var cur = new ListNode();

            while (reversed != null && head != mid)
            {
                cur.next = head;
                head = head.next;
                cur = cur.next;

                cur.next = reversed;
                reversed = reversed.next;
                cur = cur.next;
            }
        }
    }
}

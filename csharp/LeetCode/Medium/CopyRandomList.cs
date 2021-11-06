using System.Collections.Generic;
using LeetCode.DataStructures;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public RandomNode CopyRandomList(RandomNode head)
        {
            var dummyHead = new RandomNode(0);
            var originalHead = head;
            var current = dummyHead;
            var kv = new Dictionary<RandomNode, RandomNode>();
            while (head != null)
            {
                current.next = new RandomNode(head.val);
                current = current.next;
                kv.Add(head, current);
                head = head.next;
            }

            current = dummyHead.next;
            while (originalHead != null)
            {
                if (originalHead.random != null)
                {
                    current.random = kv.GetValueOrDefault(originalHead.random, null);
                }
                originalHead = originalHead.next;
                current = current.next;
            }

            return dummyHead.next;
        }
    }
}

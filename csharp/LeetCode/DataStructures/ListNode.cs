namespace LeetCode.DataStructures
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode GetListNode(params int[] list)
        {
            return GetListNode(list, 0);
        }

        private static ListNode GetListNode(int[] list, int index)
        {
            if (index == list.Length)
            {
                return null;
            }
            var next = ListNode.GetListNode(list, index + 1);
            return new ListNode(list[index], next);
        }
    }
}

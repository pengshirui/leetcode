namespace LeetCode.DataStructures
{
    public class RandomNode
    {
        public int val;
        public RandomNode next;
        public RandomNode random;

        public RandomNode(int _val)
        {
            this.val = _val;
            this.next = null;
            this.random = null;
        }
    }
}

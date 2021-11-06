namespace LeetCode.DataStructures
{
    using System.Collections.Generic;
    using System.Linq;

    public class MinStack
    {
        private readonly Stack<int> Values = new Stack<int>();
        private readonly Stack<int> Mins = new Stack<int>();
        /** initialize your data structure here. */
        public MinStack()
        {

        }

        public void Push(int val)
        {
            if (Mins.Any() && Mins.Peek() < val)
            {
                Mins.Push(Mins.Peek());
            }
            else
            {
                Mins.Push(val);
            }
            Values.Push(val);
        }

        public void Pop()
        {
            Mins.Pop();
            Values.Pop();
        }

        public int Top()
        {
            return Values.Peek();
        }

        public int GetMin()
        {
            return Mins.Peek();
        }
    }
}

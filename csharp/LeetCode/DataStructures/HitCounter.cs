namespace LeetCode.DataStructures
{
    using System.Collections.Generic;
    using System.Linq;

    public class HitCounter
    {

        private readonly Queue<int> Counter = new Queue<int>();
        public HitCounter()
        {

        }

        public void Hit(int timestamp)
        {
            while (Counter.Any() && Counter.Peek() + 300 <= timestamp)
            {
                Counter.Dequeue();
            }
            Counter.Enqueue(timestamp);
        }

        public int GetHits(int timestamp)
        {
            while (Counter.Any() && Counter.Peek() + 300 <= timestamp)
            {
                Counter.Dequeue();
            }
            return Counter.Count;
        }
    }

}

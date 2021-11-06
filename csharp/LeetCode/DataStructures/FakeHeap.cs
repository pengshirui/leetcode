namespace LeetCode.DataStructures
{
    using System.Collections.Generic;

    public class FakeHeap
    {
        private readonly List<int> List = new List<int>();

        public void Push(int val)
        {
            var pos = BinarySearch(val);
            List.Insert(pos, val);
        }

        public void Push2(int val)
        {
            var pos = List.BinarySearch(val);
            if (pos < 0)
            {
                pos = ~pos;
            }
            List.Insert(pos, val);
        }

        public int Peek()
        {
            return List[0];
        }

        public int Pop()
        {
            var top = List[0];
            List.RemoveAt(0);
            return top;
        }

        public int Count()
        {
            return List.Count;
        }

        int BinarySearch(int val)
        {
            var l = 0;
            var r = List.Count;
            while (l < r)
            {
                var m = l / 2 + r / 2;
                var middle = List[m];
                if (middle < val)
                {
                    l = m + 1;
                }
                else if (middle > val)
                {
                    r = m;
                }
                else
                {
                    return m;
                }
            }
            return r;
        }
    }
}

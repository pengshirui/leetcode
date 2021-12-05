namespace LeetCode.DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class KVHeap
    {
        const int N = (int)1e7;
        int[] heap = new int[N];
        int cnt = 0;
        Dictionary<int, List<int>> kv = new Dictionary<int, List<int>>();

        public KVHeap()
        {

        }

        public void Add(int k, int v)
        {
            kv.TryAdd(v, new List<int>());
            kv[v].Add(k);
            heap[++cnt] = v;
            Up(cnt);
        }

        public (int, int) Pop()
        {
            var (k, v) = Peek();
            kv[v].RemoveAt(0);
            Swap(1, cnt);
            cnt--;
            Down(1);
            return (k, v);
        }

        public (int, int) Peek()
        {
            var v = heap[1];
            var k = kv[v][0];
            return (k, v);

        }

        void Up(int i)
        {
            while (i / 2 > 0 && heap[i / 2] > heap[i])
            {
                Swap(i / 2, i);
            }
        }

        void Down(int i)
        {
            var t = i;
            if (2 * i <= cnt && heap[2 * i] < heap[t]) t = 2 * i;
            if (2 * i + 1<= cnt && heap[2 * i + 1] < heap[t]) t = 2 * i + 1;
            if (t != i)
            {
                Swap(t, i);
                Down(t);
            }
        }

        void Swap(int x, int y)
        {
            var t = heap[x];
            heap[x] = heap[y];
            heap[y] = t;
        }
    }
}

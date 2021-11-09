namespace LeetCode.Sort.HeapSort
{
    using System;

    public class Solution
    {
        int[] heap;
        int count = 1;
        public void HeapSort(int[] nums)
        {
            var n = nums.Length;
            heap = new int[n + 1];
            Array.Copy(nums, 0, heap, 1, n);
            count = 1 + n;

            for (var i = n / 2; i > 0; i--)
            {
                Down(i);
            }

            for (var i = 1; i <= n; i++)
            {
                nums[i - 1] = Pop();
            }
        }
        public void Add(int x)
        {
            heap[++count] = x;
            Up(count);
        }

        public int Min()
        {
            return heap[1];
        }

        public int Pop()
        {
            var min = heap[1];
            Swap(1, count - 1);
            count--;
            Down(1);
            return min;
        }

        public int Remove(int i)
        {
            var min = heap[i];
            Swap(i, count - 1);
            count--;
            Down(i);
            Up(i);
            return min;
        }

        public void Update(int i, int x)
        {
            heap[i] = x;
            Down(i);
            Up(i);
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
            if (i * 2 < count && heap[i * 2] < heap[t]) t = i * 2;
            if (i * 2 + 1 < count && heap[i * 2 + 1] < heap[t]) t = i * 2 + 1;
            if (t != i)
            {
                Swap(t, i);
                Down(t);
            }
        }

        void Swap(int i, int j)
        {
            var t = heap[i];
            heap[i] = heap[j];
            heap[j] = t;
        }
    }
}

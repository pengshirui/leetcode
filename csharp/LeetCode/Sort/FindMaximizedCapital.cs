namespace LeetCode.Sort.FindMaximizedCapital
{
    using System;

    public class Solution
    {
        (int, int)[] projects;
        public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
        {
            projects = new (int, int)[profits.Length];
            for (var i = 0; i < projects.Length; i++)
            {
                projects[i] = (capital[i], profits[i]);
            }

            Array.Sort(projects);
            var q = new Heap();
            var j = 0;
            while (k-- > 0)
            {
                while (j < projects.Length && projects[j].Item1 <= w)
                {
                    q.Add(projects[j].Item2);
                    j++;
                }
                if (q.cnt > 0)
                {
                    w += q.Pop();
                }
            }
            return w;
        }

        class Heap
        {
            public int cnt = 0;
            int[] arr = new int[(int)1e6];

            public void Add(int x)
            {
                arr[++cnt] = x;
                Up(cnt);
            }

            public int Pop()
            {
                var p = arr[1];
                Swap(1, cnt);
                cnt--;
                Down(1);
                return p;
            }

            void Up(int i)
            {
                while (i / 2 > 0 && arr[i / 2] < arr[i])
                {
                    Swap(i, i / 2);
                    i /= 2;
                }
            }

            void Down(int i)
            {
                var t = i;
                if (i * 2 <= cnt && arr[i * 2] > arr[t]) t = i * 2;
                if (i * 2 + 1 <= cnt && arr[i * 2 + 1] > arr[t]) t = i * 2 + 1;
                if (t != i)
                {
                    Swap(t, i);
                    Down(t);
                }
            }

            void Swap(int x, int y)
            {
                var t = arr[x];
                arr[x] = arr[y];
                arr[y] = t;
            }
        }
    }
}

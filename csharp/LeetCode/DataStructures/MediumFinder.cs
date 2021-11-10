namespace LeetCode.DataStructures
{
    public class MedianFinder
    {
        Heap big = new Heap(true); // min heap
        Heap small = new Heap(false); // max heap
        public MedianFinder()
        {
        }

        public void AddNum(int num)
        {
            if (big.cnt <= small.cnt)
            {
                // add to big
                if (small.Peek() > num)
                {
                    small.Add(num);
                    num = small.Pop();
                }
                big.Add(num);
            }
            else
            {
                // add to small
                if (big.Peek() < num)
                {
                    big.Add(num);
                    num = big.Pop();
                }
                small.Add(num);
            }
        }

        public double FindMedian()
        {
            if (big.cnt == small.cnt)
            {
                return (big.Peek() + small.Peek()) / 2.0;
            }
            else
            {
                return big.Peek();
            }
        }

        class Heap
        {
            int N = (int)1e5;
            int[] nums;
            int cmp = 1;
            public int cnt = 0;

            public Heap(bool min)
            {
                nums = new int[N + 10];
                cmp = min ? cmp : -1;
            }

            public void Add(int x)
            {
                nums[++cnt] = x;
                Up(cnt);
            }

            public int Peek()
            {
                return nums[1];
            }
            public int Pop()
            {
                var p = nums[1];
                Swap(1, cnt);
                cnt--;
                Down(1);
                return p;
            }

            void Up(int i)
            {
                while (i / 2 > 0 && cmp * nums[i / 2].CompareTo(nums[i]) > 0)
                {
                    Swap(i / 2, i);
                    i /= 2;
                }
            }

            void Down(int i)
            {
                var t = i;
                if (2 * i <= cnt && cmp * nums[2 * i].CompareTo(nums[t]) < 0) t = 2 * i;
                if (2 * i + 1 <= cnt && cmp * nums[2 * i + 1].CompareTo(nums[t]) < 0) t = 2 * i + 1;
                if (t != i)
                {
                    Swap(t, i);
                    Down(t);
                }
            }

            void Swap(int x, int y)
            {
                var t = nums[x];
                nums[x] = nums[y];
                nums[y] = t;
            }
        }
    }
}

namespace LeetCode.DataStructures
{
    public class Q
    {
        int[] nums;
        int hh = 0;
        int tt = -1;
        int n;
        int cnt = 0;
        public Q(int size)
        {
            n = size;
            nums = new int[n];
        }

        public void Enqueue(int x)
        {
            if (cnt < n) cnt++;
            else if (cnt == n)
            {
                hh = ++hh % n;
            }
            tt = ++tt % n;
            nums[tt] = x;
        }

        public int Peek()
        {
            return nums[hh];
        }

        public int Dequeue()
        {
            var d = nums[hh];
            hh = ++hh % n;
            cnt--;
            return d;
        }
    }

}

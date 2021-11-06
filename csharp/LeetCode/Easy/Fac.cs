namespace LeetCode.Easy.Fac
{
    public class Solution
    {
        public long Fac1(int n)
        {
            return FacInternal(n, 1);
        }

        long FacInternal(int n, int total)
        {
            if (n == 1)
            {
                return total;
            }
            return FacInternal(n - 1, total * n);
        }

        public long Fac2(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Fac2(n - 1);
        }
    }
}

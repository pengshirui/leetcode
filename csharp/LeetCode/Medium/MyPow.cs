namespace LeetCode.Medium
{
    public partial class Solution
    {
        public double MyPow(double x, int n)
        {
            if (x == 0)
            {
                return 0;
            }
            if (n == 0)
            {
                return 1;
            }
            if (n < 0)
            {
                x = 1 / x;
            }
            return n % 2 == 0 ? MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);
        }
    }
}

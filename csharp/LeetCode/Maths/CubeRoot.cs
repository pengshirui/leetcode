namespace LeetCode.Maths.CubeRoot
{
    public class Solution
    {
        public double CubeRoot(int n)
        {
            double l = -10000;
            double r = 10000;
            while (r - l > 1e-8)
            {
                var m = (r + l) / 2;
                if (m * m * m <= n)
                {
                    l = m;
                }
                else
                {
                    r = m;
                }
            }
            return l;
        }
    }
}

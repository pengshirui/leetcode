namespace LeetCode.BinarySearch.MinEatingSpeed
{
    public class Solution
    {
        int N = (int)1e9;
        public int MinEatingSpeed(int[] piles, int h)
        {
            var l = 1;
            var r = N;
            while (l < r)
            {
                var m = l / 2 + r / 2;
                if (CanEat(piles, h, m))
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }
            return l;
        }

        bool CanEat(int[] piles, int h, int k)
        {
            var hh = 0;
            foreach (var p in piles)
            {
                hh += p / k;
                if (p % k != 0)
                {
                    hh++;
                }
                if (hh > h) return false;
            }
            return hh <= h;
        }
    }
}

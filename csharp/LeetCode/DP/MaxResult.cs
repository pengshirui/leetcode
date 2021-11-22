namespace LeetCode.DP.MaxResult
{
    public class Solution
    {
        const int N = (int)1e5 + 10;
        int[] q = new int[N];
        int hh = 0;
        int tt = -1;
        int[] f = new int[N];
        public int MaxResult(int[] nums, int k)
        {
            q[++tt] = 1;
            for (int i = 1; i <= nums.Length; i++)
            {
                var num = nums[i - 1];
                if (hh <= tt && q[hh] + k < i) hh++;
                f[i] = f[q[hh]] + num;
                while (hh <= tt && f[q[tt]] <= f[i]) tt--;
                q[++tt] = i;

            }

            return f[nums.Length];
        }
    }
}

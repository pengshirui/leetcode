namespace LeetCode.Easy.CountBits
{
    public class Solution
    {
        public int[] CountBits(int n)
        {
            var res = new int[n + 1];
            for (var i = 1; i <= n; i++)
            {
                res[i] = res[i & (i - 1)] + 1;
            }
            return res;
        }
    }
}

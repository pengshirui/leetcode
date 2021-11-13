namespace LeetCode.Monotonic.DailyTemperatures
{
    public class Solution
    {
        int[] q;
        int[] res;
        int hh = 0;
        int tt = -1;
        public int[] DailyTemperatures(params int[] temperatures)
        {
            res = new int[temperatures.Length];
            q = new int[temperatures.Length + 10];
            for (var i = res.Length - 1; i >= 0; i--)
            {
                var j = 0;
                while (hh <= tt && temperatures[i] >= temperatures[q[tt]])
                {
                    tt--;
                }
                if (hh <= tt && temperatures[i] < temperatures[q[tt]])
                {
                    j = q[tt] - i;
                }
                res[i] = j;
                q[++tt] = i;
            }
            return res;
        }
    }
}

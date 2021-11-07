namespace LeetCode.Bit.IpToCIDR
{
    using System.Collections.Generic;

    public class Solution
	{
		public List<string> IpToCIDR(string ip, int range)
		{
			long x = 0;
			string[] ips = ip.Split(".");
			for (int i = 0; i < ips.Length; ++i)
			{
				x = int.Parse(ips[i]) + x * 256;
			}

			List<string> res = new List<string>();
			while (range > 0)
			{
				long step = x & -x;
				step = step == 0 ? 1 : step;
				while (step > range) step /= 2;
				res.Add(LongToIP(x, (int)step));
				x += step;
                range -= (int)step;
			}

			return res;
		}

		string LongToIP(long x, int step)
		{
			int[] ans = new int[4];
			ans[0] = (int)(x & 255); x >>= 8;
			ans[1] = (int)(x & 255); x >>= 8;
			ans[2] = (int)(x & 255); x >>= 8;
			ans[3] = (int)x;
			int len = 33;
			while (step > 0)
			{
				len--;
				step /= 2;
			}
			return ans[3] + "." + ans[2] + "." + ans[1] + "." + ans[0] + "/" + len;
		}
	}
}

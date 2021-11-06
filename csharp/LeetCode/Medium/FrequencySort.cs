namespace LeetCode.Medium.FrequencySort
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Solution
    {
        public string FrequencySort(string s)
        {
            var dict = new Dictionary<char, int>();
            foreach (var c in s)
            {
                dict.TryAdd(c, 0);
                dict[c]++;
            }

            var sb = new StringBuilder();
            foreach (var (k, v) in dict.OrderByDescending(d => d.Value))
            {
                int times = v;
                while (times-- > 0)
                    sb.Append(k);
            }
            return sb.ToString();
        }
    }
}

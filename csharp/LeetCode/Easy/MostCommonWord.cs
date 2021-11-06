namespace LeetCode.Easy
{
    using System.Collections.Generic;

    public partial class Solution
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var counts = new Dictionary<string, int>();
            for (int i = 0; i < paragraph.Length;)
            {
                var s = "";
                while (i < paragraph.Length && char.IsLetter(paragraph[i]))
                {
                    s += char.ToLower(paragraph[i]);
                    i++;
                }

                while (i < paragraph.Length && !char.IsLetter(paragraph[i]))
                {
                    i++;
                }
                counts.TryAdd(s, 0);
                counts[s]++;
            }
            foreach (var b in banned)
                counts[b] = 0;
            var ans = "";
            var count = 0;

            foreach (var (k, v) in counts)
            {
                if (v > count)
                {
                    count = v;
                    ans = k;
                }
            }
            return ans;
        }
    }
}

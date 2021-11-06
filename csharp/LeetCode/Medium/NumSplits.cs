namespace LeetCode.Medium.NumSplits
{
    using System.Collections.Generic;

    public class Solution
    {
        public int NumSplits(string s)
        {
            var first = new HashSet<char>();
            var second = new Dictionary<char, int>();
            foreach (var c in s)
            {
                second.TryAdd(c, 0);
                second[c]++;
            }
            var result = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (!first.Contains(c))
                {
                    first.Add(c);
                }
                second[c]--;
                if (second[c] == 0)
                {
                    second.Remove(c);
                }
                if (first.Count == second.Keys.Count)
                {
                    result++;
                }
                else if (first.Count > second.Keys.Count)
                {
                    break;
                }
            }
            return result;
        }
    }
}

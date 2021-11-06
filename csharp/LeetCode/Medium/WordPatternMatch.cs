namespace LeetCode.Medium.WordPatternMatch
{
    using System.Collections.Generic;

    public class Solution
    {
        public bool WordPatternMatch(string pattern, string s)
        {
            // dictionary('a' : "r")
            return IsMatch(pattern, 0, s, 0, new Dictionary<char, string>(), new HashSet<string>());
        }

        bool IsMatch(string p, int i, string s, int j, Dictionary<char, string> kv, HashSet<string> words)
        {
            if (i == p.Length || j == s.Length)
            {
                return i == p.Length && j == s.Length;
            }
            // existing pattern
            if (kv.TryGetValue(p[i], out var val))
            {
                // find a substring matches the saved pattern string
                for (var k = 1; j + k <= s.Length; k++)
                {
                    var str = s.Substring(j, k);
                    if (!val.StartsWith(str))
                    {
                        return false;
                    }
                    if (str == val)
                    {
                        return IsMatch(p, i + 1, s, j + k, kv, words);
                    }
                }
            }
            else
            {
                // new pattern
                for (var k = 1; j + k <= s.Length; k++)
                {
                    var str = s.Substring(j, k);
                    if (words.Contains(str)) continue;
                    kv.Add(p[i], str);
                    words.Add(str);
                    if (IsMatch(p, i + 1, s, j + k, kv, words))
                    {
                        return true;
                    }
                    kv.Remove(p[i]);
                    words.Remove(str);
                }
            }
            return false;
        }

    }
}

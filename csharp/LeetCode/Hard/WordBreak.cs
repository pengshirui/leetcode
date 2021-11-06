namespace LeetCode.Hard.WordBreak
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        private readonly Dictionary<string, IList<string>> Memo = new Dictionary<string, IList<string>>();
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            var hs = new HashSet<string>(wordDict);
            return DFS(s, hs);
        }

        IList<string> DFS(string s, HashSet<string> hs)
        {
            if (Memo.ContainsKey(s))
            {
                return Memo[s];
            }
            var result = new List<string>();
            if (hs.Contains(s))
            {
                result.Add(s);
            }
            for (var i = 1; i < s.Length; i++)
            {
                var left = s.Substring(0, i);
                if (!hs.Contains(left))
                {
                    continue;
                }
                var right = s.Substring(i);
                var rightList = DFS(right, hs);

                foreach (var r in rightList)
                {
                    result.Add($"{left} {r}");
                }
            }
            Memo[s] = result;
            return result;
        }
    }
}

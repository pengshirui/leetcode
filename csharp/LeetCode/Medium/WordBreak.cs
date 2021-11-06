namespace LeetCode.Medium.WordBreak
{
    using System.Collections.Generic;

    public class Solution
    {
        private readonly Dictionary<string, bool> Memo = new Dictionary<string, bool>();
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var hs = new HashSet<string>(wordDict);
            return DFS(s, hs);
        }

        bool DFS(string s, HashSet<string> hs)
        {
            if (Memo.ContainsKey(s))
            {
                return Memo[s];
            }

            if (hs.Contains(s))
            {
                return true;
            }

            for (var i = 1; i < s.Length; i++)
            {
                var left = s.Substring(0, i);
                if (!hs.Contains(left))
                {
                    continue;
                }
                var right = s.Substring(i);
                var hasRight = DFS(right, hs);
                Memo[right] = hasRight;
                if (hasRight)
                {
                    return true;
                }
            }
            Memo[s] = false;
            return false;
        }
    }
}

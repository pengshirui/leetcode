using System.Collections.Generic;

namespace LeetCode.Hard
{
    public partial class Solution
    {
        private readonly char Star = '*';
        private readonly char Dot = '.';
        private readonly Dictionary<(int, int), bool> MatchMemo = new Dictionary<(int, int), bool>();
        public bool IsMatch(string s, string p)
        {
            return IsMatchInternal(s, p, 0, 0);
        }

        private bool IsMatchInternal(string s, string p, int i, int j)
        {
            if (MatchMemo.TryGetValue((i, j), out var value))
            {
                return value;
            }
            if (i >= s.Length && j >= p.Length)
            {
                return true;
            }
            if (j >= p.Length)
            {
                return false;
            }

            var match = i < s.Length && (s[i] == p[j] || p[j] == Dot);
            if (j + 1 < p.Length && p[j + 1] == Star)
            {
                MatchMemo[(i, j)] = IsMatchInternal(s, p, i, j + 2) || // don't use star
                    (match && IsMatchInternal(s, p, i + 1, j)); // use *
                return MatchMemo[(i, j)];
            }
            if (match)
            {
                MatchMemo[(i, j)] = IsMatchInternal(s, p, i + 1, j + 1);
                return MatchMemo[(i, j)];
            }
            MatchMemo[(i, j)] = false;
            return false;
        }
    }
}

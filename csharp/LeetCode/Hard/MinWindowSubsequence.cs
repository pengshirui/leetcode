namespace LeetCode.Hard.MinWindowSubsequence
{
    public class Solution
    {
        public string MinWindowSubsequence(string s, string t)
        {
            var m = s.Length;
            var n = t.Length;
            var r = 0;
            var start = -1;
            var len = int.MaxValue;
            while (r < m)
            {
                int ptr = 0;
                // use fast pointer to find the last character of T in S
                while (r < m)
                {
                    if (s[r] == t[ptr])
                    {
                        ptr++;
                    }
                    if (ptr == n) break;
                    r++;
                }
                if (r == m) break;
                // use another slow pointer to traverse from right to left until find first character of T in S
                var l = r;
                ptr = n - 1;
                while (ptr >= 0)
                {
                    if (s[l] == t[ptr])
                    {
                        ptr--;
                    }
                    if (ptr < 0) break;
                    l--;
                }

                if (r - l + 1 < len)
                {
                    len = r - l + 1;
                    start = l;
                }
                // WARNING: we have to move right pointer to the next position of left pointer, NOT the next position
                // of right pointer
                r = l + 1;
            }

            return start == -1 ? string.Empty : s.Substring(start, len);
        }
    }
}

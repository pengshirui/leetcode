using System.Collections.Generic;

namespace LeetCode.Hard
{
    public partial class Solution
    {
        public string MinWindow(string s, string t)
        {
            var dictOfT = new int[128];
            foreach (var ch in t)
                dictOfT[ch - 'A']++;
            var count = t.Length;
            var l = 0;
            var r = 0;
            var minLen = int.MaxValue;
            var startIndex = 0;
            while (r < s.Length)
            {
                if (dictOfT[s[r] - 'A'] > 0)
                    count--;
                dictOfT[s[r] - 'A']--;
                r++;
                while (count == 0)
                {
                    if (minLen > r - l)
                    {
                        startIndex = l;
                        minLen = r - l;
                    }
                    if (dictOfT[s[l] - 'A'] == 0)
                        count++;
                    dictOfT[s[l] - 'A']++;
                    l++;
                }
            }
            return minLen == int.MaxValue ? "" : s.Substring(startIndex, minLen);
        }
    }
}

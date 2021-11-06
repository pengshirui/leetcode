namespace LeetCode.Medium
{
    using System.Collections.Generic;

    public partial class Solution
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var ans = new List<int>();
            var charsInP = new int[26];
            foreach (var c in p)
            {
                charsInP[c - 'a']++;
            }
            var total = p.Length;

            var window = new AnagramsInfo(total);
            var leftMost = s[0];
            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];
                window.Add(c);
                if (window.Count > window.Capacity)
                {
                    window.Remove(leftMost);
                }
                if (window.Count == window.Capacity)
                {
                    if (IsMatch(charsInP, window.CharCounts))
                    {
                        ans.Add(i - total + 1);
                    }
                    leftMost = s[i - total + 1];
                }
            }
            return ans;
        }

        bool IsMatch(int[] charsInP, int[] charCounts)
        {
            for (var j = 0; j < charsInP.Length; j++)
            {
                if (charCounts[j] != charsInP[j])
                {
                    return false;
                }
            }
            return true;
        }

        class AnagramsInfo
        {
            public int[] CharCounts { get; set; }
            public int Capacity { get; set; }
            public int Count { get; set; }

            public AnagramsInfo(int size)
            {
                CharCounts = new int[26];
                Capacity = size;
            }

            public int Add(char c)
            {
                var key = c - 'a';
                CharCounts[key]++;
                Count++;
                return CharCounts[key];
            }

            public int Remove(char c)
            {
                var key = c - 'a';
                CharCounts[key]--;
                Count--;
                return CharCounts[key];
            }
        }

    }
}

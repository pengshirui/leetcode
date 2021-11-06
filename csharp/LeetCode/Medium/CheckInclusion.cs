namespace LeetCode.Medium
{
    public partial class Solution
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;
            var s1CharCounts = new int[26];
            foreach (var c in s1)
            {
                s1CharCounts[c - 'a']++;
            }

            var window = new Window(s1.Length);
            char lastChar = ' ';
            for (var i = 0; i < s2.Length; i++)
            {
                var c = s2[i];
                window.Add(c);
                if (window.Count > window.Capacity)
                {
                    window.Remove(lastChar);
                }
                if (window.Count == window.Capacity)
                {
                    // check two int[] are the same;
                    if (IsSame(window.CharCounts, s1CharCounts))
                        return true;
                    lastChar = s2[i - s1.Length + 1];
                }

            }
            return false;
        }

        bool IsSame(int[] r1, int[] r2)
        {
            for (var i = 0; i < r1.Length; i++)
            {
                if (r1[i] != r2[i])
                    return false;
            }
            return true;
        }

        class Window
        {
            public int Capacity { get; set; }
            public int Count { get; set; }
            public int[] CharCounts { get; set; }
            public Window(int cap)
            {
                Capacity = cap;
                CharCounts = new int[26];
            }

            public int Add(char c)
            {
                CharCounts[c - 'a']++;
                Count++;
                return CharCounts[c - 'a'];
            }

            public int Remove(char c)
            {
                CharCounts[c - 'a']--;
                Count--;
                return CharCounts[c - 'a'];
            }

        }

    }
}

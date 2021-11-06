namespace LeetCode.Hard
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solution
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            var s1 = new HashSet<int>();
            var s2 = new HashSet<int>();
            var s1Visited = new bool[wordList.Count];
            var s2Visited = new bool[wordList.Count];
            var beginChars = beginWord.ToCharArray();
            for (var i = 0; i < wordList.Count; i++)
            {
                if (IsNeighbour(beginChars, wordList, i))
                {
                    s1Visited[i] = true;
                    s1.Add(i);
                }
                if (endWord == wordList[i])
                {
                    s2Visited[i] = true;
                    s2.Add(i);
                }
            }

            var ans = 2;
            while (s1.Any() && s2.Any())
            {
                if (s1.Intersect(s2).Any())
                {
                    return ans;
                }
                if (s1.Count < s2.Count)
                {
                    s1 = GetNewSet(wordList, s1, s1Visited);
                }
                else
                {
                    s2 = GetNewSet(wordList, s2, s2Visited);
                }
                ans++;
            }

            return 0;
        }

        private HashSet<int> GetNewSet(IList<string> wordList, HashSet<int> s, bool[] visited)
        {
            var set = new HashSet<int>();
            foreach (var index in s)
            {
                var chars = wordList[index].ToCharArray();
                for (var i = 0; i < wordList.Count; i++)
                {
                    if (!visited[i] && IsNeighbour(chars, wordList, i))
                    {
                        visited[i] = true;
                        set.Add(i);
                    }
                }
            }

            return set;
        }

        bool IsNeighbour(char[] s, IList<string> wordList, int i)
        {
            if (s.Length != wordList[i].Length)
            {
                return false;
            }
            var k = 0;
            var diffCount = 0;
            while (k < s.Length)
            {
                if (s[k] != wordList[i][k])
                {
                    diffCount++;
                }
                if (diffCount > 1)
                {
                    return false;
                }
                k++;
            }
            return true;
        }
    }
}

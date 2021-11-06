namespace LeetCode.Hard.FindLadders
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            var ans = new List<IList<string>>();
            var wordSet = new HashSet<string>(wordList);
            if (!wordSet.Contains(endWord))
            {
                return ans;
            }
            var q = new Queue<IList<string>>();
            q.Enqueue(new List<string> { beginWord });
            var visited = new HashSet<string>();
            while (q.Any())
            {
                var count = q.Count;
                while (count-- > 0)
                {
                    var currentPath = q.Dequeue();
                    var lastStr = currentPath.Last();
                    var neighbors = GetNeighbors(lastStr, wordSet);
                    foreach (var n in neighbors)
                    {
                        visited.Add(n);
                        var newPath = new List<string>(currentPath);
                        newPath.Add(n);
                        if (n == endWord)
                        {
                            ans.Add(newPath);
                        }
                        else
                        {
                            q.Enqueue(newPath);
                        }
                    }
                }

                foreach (var v in visited)
                {
                    wordSet.Remove(v);
                }

            }
            return ans;
        }

        private List<string> GetNeighbors(string word, HashSet<string> wordSet)
        {
            var neighbors = new List<string>();
            for (var i = 0; i < word.Length; i++)
            {
                var ch = word.ToCharArray();
                for (char c = 'a'; c <= 'z'; c++)
                {
                    ch[i] = c;
                    var str = new string(ch);
                    if (wordSet.Contains(str))  // only get valid neighbors
                        neighbors.Add(str);
                }
            }
            return neighbors;
        }
    }
}

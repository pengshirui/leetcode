namespace LeetCode.Hard.PalindromePairs
{
    using System.Collections.Generic;

    public class Solution
    {
        public IList<IList<int>> PalindromePairs(string[] words)
        {
            // build trie
            var root = new Trie();
            for (var i = 0; i < words.Length; i++)
            {
                AddWord(root, words, i);
            }
            // Search trie
            var result = new List<IList<int>>();
            for (var i = 0; i < words.Length; i++)
            {
                var hits = Search(root, words, i);
                foreach (var j in hits)
                {
                    if (i == j) continue;
                    result.Add(new List<int> { i, j });
                }
            }
            return result;
        }

        void AddWord(Trie root, string[] words, int i)
        {
            for (var j = words[i].Length - 1; j >= 0; j--)
            {
                var next = words[i][j] - 'a';
                if (root.Next[next] == null)
                {
                    root.Next[next] = new Trie();
                }
                root.Indices.Add(i);
                root = root.Next[next];
            }
            root.Index = i;
        }

        IList<int> Search(Trie root, string[] words, int i)
        {

            var result = new List<int>();
            for (var j = 0; j < words[i].Length; j++)
            {
                // check if current words[i] is pal from j to the end
                if (root.Index != -1 && IsPalindorme(words[i], j, words[i].Length - 1))
                {
                    result.Add(root.Index);
                }
                var next = words[i][j] - 'a';
                if (root.Next[next] == null)
                {
                    return result;
                }
                root = root.Next[next];

            }
            if (root.Index != -1)
            {
                result.Add(root.Index);
            }
            foreach (var index in root.Indices)
            {
                // check if the current word[index] is pal from 0 to the rest unused length
                if (IsPalindorme(words[index], 0, words[index].Length - words[i].Length - 1))
                {
                    result.Add(index);
                }
            }
            return result;
        }

        bool IsPalindorme(string pair, int i, int j)
        {
            while (i < j)
            {
                if (pair[i++] != pair[j--])
                {
                    return false;
                }
            }
            return true;
        }
    }

    class Trie
    {
        public Trie[] Next = new Trie[26];
        public int Index = -1;
        public IList<int> Indices = new List<int>();
    }
}

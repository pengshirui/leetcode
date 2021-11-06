
namespace LeetCode.Hard
{
    using System.Collections.Generic;
    using System.Text;

    public partial class Solution
    {
        public IList<IList<string>> WordSquares(params string[] words)
        {
            var root = BuildTrie(words);

            var result = new List<IList<string>>();
            foreach (var word in words)
            {
                DFS(result, new List<string> { word }, word.Length, root);
            }
            return result;
        }

        Trie BuildTrie(string[] words)
        {
            var root = new Trie();
            foreach (var word in words)
            {
                var cur = root;
                foreach (var c in word)
                {
                    if (cur.Next[c - 'a'] == null)
                    {
                        cur.Next[c - 'a'] = new Trie();
                    }
                    cur = cur.Next[c - 'a'];
                    cur.Words.Add(word);
                }
            }
            return root;
        }

        void DFS(IList<IList<string>> result, IList<string> words, int count, Trie root)
        {
            if (words.Count == count)
            {
                result.Add(new List<string>(words));
                return;
            }

            var prefix = new StringBuilder();
            foreach (var word in words)
            {
                // b a l l 
                // a r e a
                // prefix = "le", index = 2 // length
                prefix.Append(word[words.Count]);
            }
            var candidates = FindCandidates(prefix, root);
            foreach (var candidate in candidates)
            {
                words.Add(candidate);
                DFS(result, words, count, root);
                words.RemoveAt(words.Count - 1);
            }
        }

        IList<string> FindCandidates(StringBuilder prefix, Trie root)
        {
            var cur = root;
            var i = 0;
            while (i < prefix.Length)
            {
                if (cur.Next[prefix[i] - 'a'] == null)
                {
                    return new List<string>();
                }
                cur = cur.Next[prefix[i] - 'a'];
                i++;
            }
            return i == prefix.Length ? cur.Words : new List<string>();
        }
    }

    partial class Trie
    {
        public IList<string> Words = new List<string>();
        public Trie[] Next = new Trie[26];
    }
}

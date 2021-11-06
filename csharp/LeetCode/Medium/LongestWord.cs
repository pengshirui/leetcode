namespace LeetCode.Medium.LongestWord
{
    using System;

    public class Solution
    {
        public string LongestWord(string[] words)
        {
            Array.Sort(words);

            var root = new Trie
            {
                IsRoot = true
            };
            foreach (var word in words)
            {
                BuildTrie(root, word);
            }

            return Search(root);
        }

        void BuildTrie(Trie root, string word)
        {
            foreach (var c in word)
            {
                if (!root.IsRoot && root.Word == null) return;
                if (root.Next[c - 'a'] == null)
                {
                    root.Next[c - 'a'] = new Trie();
                }
                root = root.Next[c - 'a'];
            }
            root.Word = word;
        }

        string Search(Trie root)
        {
            var res = string.Empty;
            if (root.Word != null)
            {
                res = root.Word;
            }
            foreach (var n in root.Next)
            {
                if (n != null && n.Word != null)
                {
                    var w = Search(n);
                    if (w.Length > res.Length)
                    {
                        res = w;
                    }
                }
            }
            return res;
        }
    }

    class Trie
    {
        public string Word;
        public bool IsRoot { get; set; }
        public Trie[] Next = new Trie[26];
    }
}

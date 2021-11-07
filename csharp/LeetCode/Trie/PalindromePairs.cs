namespace LeetCode.Trie.PalindromePairs
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        public IList<IList<int>> PalindromePairs(string[] words)
        {
            var root = new Trie();
            for (var i = 0; i < words.Length; i++)
            {
                var r = words[i].ToCharArray();
                Array.Reverse(r);
                root.Insert(new string(r), i);
            }

            var result = new List<IList<int>>();
            for (var i = 0; i < words.Length; i++)
            {
                var hits = root.Search(words[i]);
                foreach (var j in hits)
                {
                    if (i == j) continue;
                    var str = words[i] + words[j];
                    if (IsPal(str))
                    {
                        result.Add(new List<int> { i, j });
                    }
                }
            }

            return result;
        }

        bool IsPal(string s)
        {
            var i = 0;
            var j = s.Length - 1;
            while (i < j)
            {
                if (s[i++] != s[j--]) return false;
            }
            return true;
        }

        class Trie
        {
            int Id = -1;
            Trie[] Next = new Trie[26];

            public void Insert(string w, int id)
            {
                Trie t = this;
                foreach (var c in w)
                {
                    if (t.Next[c - 'a'] == null)
                    {
                        t.Next[c - 'a'] = new Trie();
                    }
                    t = t.Next[c - 'a'];
                }
                t.Id = id;
            }

            public IList<int> Search(string w)
            {
                var res = new List<int>();
                Trie t = this;
                foreach (var c in w)
                {
                    if (t.Id != -1)
                    {
                        res.Add(t.Id);
                    }
                    if (t.Next[c - 'a'] == null) return res;
                    t = t.Next[c - 'a'];
                }

                DFS(t, res);
                return res;
            }

            void DFS(Trie t, IList<int> res)
            {
                if (t.Id != -1)
                {
                    res.Add(t.Id);
                }

                foreach (var n in t.Next)
                {
                    if (n != null)
                        DFS(n, res);
                }
            }
        }
    }
}

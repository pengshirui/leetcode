namespace LeetCode.Hard.FindWords
{
    using System.Collections.Generic;

    public class Solution
    {
        private int M = 0;
        private int N = 0;
        public IList<string> FindWords(char[][] board, string[] words)
        {
            var root = BuildTrie(words);

            M = board.Length;
            N = board[0].Length;
            var result = new List<string>();
            for (var i = 0; i < M; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    DFS(result, board, i, j, root);
                }
            }
            return result;
        }

        void DFS(IList<string> result, char[][] board, int x, int y, Trie root)
        {
            var c = board[x][y];
            if (c == '#' || root.Next[c - 'a'] == null)
            {
                return;
            }
            root = root.Next[c - 'a'];
            if (!string.IsNullOrEmpty(root.Word))
            {
                result.Add(root.Word);
                root.Word = null; // de-dup
            }
            board[x][y] = '#';
            if (x - 1 >= 0)
            {
                DFS(result, board, x - 1, y, root);
            }
            if (x + 1 < M)
            {
                DFS(result, board, x + 1, y, root);
            }
            if (y - 1 >= 0)
            {
                DFS(result, board, x, y - 1, root);
            }
            if (y + 1 < N)
            {
                DFS(result, board, x, y + 1, root);
            }
            board[x][y] = c;
        }

        Trie BuildTrie(string[] words)
        {
            var root = new Trie();
            foreach (var word in words)
            {
                var cur = root;
                for (var i = 0; i < word.Length; i++)
                {
                    if (cur.Next[word[i] - 'a'] == null)
                    {
                        cur.Next[word[i] - 'a'] = new Trie();
                    }
                    cur = cur.Next[word[i] - 'a'];
                    if (i == word.Length - 1)
                    {
                        cur.Word = word;
                    }
                }
            }
            return root;
        }

        class Trie
        {
            public Trie[] Next = new Trie[26];
            public IList<string> Words = new List<string>();
            public string Word { get; set; }
        }
    }
}

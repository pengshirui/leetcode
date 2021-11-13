namespace LeetCode.DFS.FindWords
{
    using System.Collections.Generic;

    public class Solution
    {
        int m, n;
        Trie root = new Trie();
        List<string> res = new List<string>();
        int[,] Directions =
        {
            { 1, 0 }, { -1, 0 },
            { 0, 1 }, { 0, -1 },
        };
        string[] Words;
        char[][] Board;
        public IList<string> FindWords(char[][] board, string[] words)
        {
            m = board.Length;
            n = board[0].Length;
            Words = words;
            Board = board;
            for (var i = 0; i < words.Length; i++)
            {
                root.Insert(i, words[i]);
            }

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var c = board[i][j];
                    DFS(root.next[c - 'a'], i, j);
                }
            }
            return res;
        }

        void DFS(Trie t, int i, int j)
        {
            if (t == null)
            {
                return;
            }
            var c = Board[i][j];
            Board[i][j] = '#';
            if (t.id >= 0)
            {
                res.Add(Words[t.id]);
                t.id = -1;
            }
            for (var d = 0; d < 4; d++)
            {
                var x = i + Directions[d, 0];
                var y = j + Directions[d, 1];
                if (x < 0 || x >= m || y < 0 || y >= n || Board[x][y] == '#') continue;
                DFS(t.next[Board[x][y] - 'a'], x, y);
            }
            Board[i][j] = c;
        }

        class Trie
        {
            public Trie[] next = new Trie[26];
            public int id = -1;

            public void Insert(int id, string w)
            {
                var cur = this;
                foreach (var c in w)
                {
                    if (cur.next[c - 'a'] == null) cur.next[c - 'a'] = new Trie();
                    cur = cur.next[c - 'a'];
                }
                cur.id = id;
            }
        }
    }
}

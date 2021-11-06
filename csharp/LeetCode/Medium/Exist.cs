namespace LeetCode.Medium
{
    public partial class Solution
    {
        readonly int[][] Directions = new int[][]
        {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 },
        };

        public bool Exist(char[][] board, string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return false;
            }
            var m = board.Length;
            var n = board[0].Length;
            // (x, y)
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        var oldChar = word[0];
                        board[i][j] = '#';
                        if (DFS(board, i, j, word, 1))
                        {
                            return true;
                        }
                        board[i][j] = oldChar;
                    }
                }
            }
            return false;
        }

        bool DFS(char[][] board, int x, int y, string word, int k)
        {
            if (k == word.Length)
            {
                return true;
            }

            foreach (var d in Directions)
            {
                var nx = x + d[0];
                var ny = y + d[1];
                if (nx < 0 || nx >= board.Length || ny < 0 || ny >= board[0].Length || board[nx][ny] != word[k])
                {
                    continue;
                }
                var oldChar = word[0];
                board[nx][ny] = '#';
                if (DFS(board, nx, ny, word, k + 1))
                {
                    return true;
                }
                board[nx][ny] = oldChar;
            }
            return false;
        }
    }
}

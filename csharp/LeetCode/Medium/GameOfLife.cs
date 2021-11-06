namespace LeetCode.Medium.GameOfLife
{
    using System;

    public class Solution
    {
        private int m;
        private int n;
        public void GameOfLife(int[][] board)
        {
            m = board.Length;
            n = board[0].Length;
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var c = GetLiveCount(board, i, j);
                    if (board[i][j] == 1 && (c < 2 || c > 3)) board[i][j] = -1;
                    if (board[i][j] == 0 && c == 3) board[i][j] = 2;
                }
            }
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (board[i][j] == -1) board[i][j] = 0;
                    if (board[i][j] == 2) board[i][j] = 1;
                }
            }
        }

        private readonly int[] Dirs = new int[] { 0, 1, -1 };
        int GetLiveCount(int[][] board, int x, int y)
        {
            var res = 0;
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (i == 0 && j == 0) continue;
                    var newX = x + Dirs[i];
                    var newY = y + Dirs[j];
                    if (newX >= 0 && newX < m && newY >= 0 && newY < n && Math.Abs(board[newX][newY]) == 1) res++;
                    if (res > 3) return res;
                }
            }
            return res;
        }
    }
}

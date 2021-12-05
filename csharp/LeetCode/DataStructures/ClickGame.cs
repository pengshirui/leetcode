namespace LeetCode.DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ClickGame
    {
        int[][] b;
        int m;
        int n;
        int[] dx = { -1, 0, 1, 0 };
        int[] dy = { 0, -1, 0, 1 };
        public ClickGame(int[][] board)
        {
            b = board;
            m = board.Length;
            n = board[0].Length;
        }

        public void Click(int x, int y)
        {
            if (x < 0 || x >= m || y < 0 || y >= n) return;
            var empty = new (int, int)[3];
            var mid = 1;
            var t = b[x][y];
            b[x][y] = 0;
            empty[mid] = (x, y);
            for (var d = 0; d < 4; d++)
            {
                var x1 = x + dx[d];
                var y1 = y + dy[d];
                if (x1 < 0 || x1 >= m || y1 < 0 || y1 >= n) continue;
                if (b[x1][y1] == t)
                {
                    b[x1][y1] = 0;
                    if (empty[mid + dy[d]].Item1 < x1)
                    {
                        empty[mid + dy[d]] = (x1, y1);
                    }
                }
            }

            for (var i = 0; i < 3; i++)
            {
                var (u, v) = empty[i];
                if (b[u][v] == 0)
                    Down(u, v);
            }
        }

        public int[][] Get()
        {
            return b;
        }

        void Down(int row, int col)
        {
            var i = row;
            while (i >= 0 && b[i][col] == 0) i--;
            for (; i >= 0; i--)
            {
                Swap(i, col, row, col);
                row--;
            }
        }

        void Swap(int x, int y, int u, int v)
        {
            var t = b[x][y];
            b[x][y] = b[u][v];
            b[u][v] = t;
        }
    }
}

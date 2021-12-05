namespace LeetCode.DFS.SolveSudoku
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        const int N = 9;
        const int M = 1 << N;
        int[] row = new int[N];
        int[] col = new int[N];
        int[,] cel = new int[3, 3];

        int[] slots = new int[M];
        public void SolveSudoku(char[][] board)
        {
            Init();

            var cnt = 0;
            for (var i = 0; i < N; i++)
                for (var j = 0; j < N; j++)
                {
                    if (board[i][j] == '.') cnt++;
                    else
                    {
                        var t = board[i][j] - '1';
                        Update(board, i, j, t, true);
                    }
                }

            DFS(board, cnt);
        }

        bool DFS(char[][] board, int cnt)
        {
            if (cnt == 0) return true;
            var (x, y) = GetMinSlot(board);
            var s = Get(x, y);
            for (var i = s; i != 0; i -= LowBit(i))
            {
                var t = (int)Math.Log2(LowBit(i));
                Update(board, x, y, t, true);
                if (DFS(board, cnt - 1)) return true;
                Update(board, x, y, t, false);
            }
            return false;
        }

        int LowBit(int x)
        {
            return x & -x;
        }

        (int, int) GetMinSlot(char[][] board)
        {
            var min = 10;
            var x = 0;
            var y = 0;

            for (var i = 0; i < N; i++)
                for (var j = 0; j < N; j++)
                {
                    if (board[i][j] == '.')
                    {
                        var slot = slots[Get(i, j)];
                        if (slot < min)
                        {
                            min = slot;
                            x = i;
                            y = j;
                        }
                        if (min == 1)
                            return (x, y);
                    }
                }
            return (x, y);
        }

        int Get(int i, int j)
        {
            return row[i] & col[j] & cel[i / 3, j / 3];
        }

        void Update(char[][] board, int i, int j, int t, bool isSet)
        {
            if (isSet)
            {
                board[i][j] = (char)(t + '1');
            }
            else
            {
                board[i][j] = '.';
            }
            var v = 1 << t;
            if (!isSet) v = -v;
            row[i] -= v;
            col[j] -= v;
            cel[i / 3, j / 3] -= v;
        }

        void Init()
        {
            for (var i = 0; i < M; i++)
                for (var j = 0; j < N; j++)
                    slots[i] += (i >> j) & 1;
            for (var i = 0; i < N; i++)
                row[i] = col[i] = (1 << N) - 1;
            for (var i = 0; i < 3; i++)
                for (var j = 0; j < 3; j++)
                    cel[i, j] = (1 << N) - 1;
        }

        public void SolveSudoku2(char[][] board)
        {
            if (board == null || board.Length == 0)
            {
                return;
            }

            DFS(board);
        }

        public bool DFS(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                    {
                        for (var num = '1'; num <= '9'; num++)
                        {
                            if (IsValid(board, i, j, num))
                            {
                                board[i][j] = num;

                                if (DFS(board))
                                {
                                    return true;
                                }
                                else
                                {
                                    // backtracking: reset the cell before going back the previous recursion level
                                    board[i][j] = '.';
                                }
                            }
                        }

                        // tried 1-9 for current cell, but no available value
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsValid(char[][] board, int row, int col, char num)
        {
            for (int i = 0; i < 9; i++)
            {
                // check neither row nor colum already has num
                if (board[row][i] == num || board[i][col] == num)
                {
                    return false;
                }

                // start row and col index of corresponding box
                var r = 3 * (row / 3);
                var c = 3 * (col / 3);

                // check the 9 cells of the corresponding box
                // i / 3 is equivalent to 0, 0, 0, 1, 1, 1, 2, 2, 2
                // i % 3 is equivalent to 0, 1, 2, 0, 1, 2, 0, 1, 2
                if (board[r + i / 3][c + i % 3] == num)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

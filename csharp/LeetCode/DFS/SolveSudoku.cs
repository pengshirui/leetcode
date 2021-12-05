namespace LeetCode.DFS.SolveSudoku
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        public void SolveSudoku(char[][] board)
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

namespace LeetCode.DataStructures
{
    using System;

    public class TicTacToe
    {

        private readonly int[] Rows;
        private readonly int[] Cols;
        int Diagonal;
        int AntiDiagnal;
        private readonly int N;
        /** Initialize your data structure here. */
        public TicTacToe(int n)
        {
            Rows = new int[n];
            Cols = new int[n];
            N = n;
        }

        /** Player {player} makes a move at ({row}, {col}).
            @param row The row of the board.
            @param col The column of the board.
            @param player The player, can be either 1 or 2.
            @return The current winning condition, can be either:
                    0: No one wins.
                    1: Player 1 wins.
                    2: Player 2 wins. */
        public int Move(int row, int col, int player)
        {
            var change = player == 1 ? 1 : -1;
            if (row == col)
            {
                Diagonal += change;
            }
            if (row + col == N - 1)
            {
                AntiDiagnal += change;
            }
            Rows[row] += change;
            Cols[col] += change;

            if (Math.Abs(Diagonal) == N || Math.Abs(AntiDiagnal) == N || Math.Abs(Rows[row]) == N || Math.Abs(Cols[col]) == N)
            {
                return player;
            }
            else
            {
                return 0;
            }

        }
    }
}

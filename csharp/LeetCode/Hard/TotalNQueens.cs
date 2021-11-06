namespace LeetCode.Hard.TotalNQueens
{
    public class Solution
    {
        public int TotalNQueens(int n)
        {
            // queen position by row number
            var board = new int[n];
            var result = DFS(0, board, 0);
            return result;
        }

        int DFS(int result, int[] board, int row)
        {
            if (row == board.Length)
            {
                return result + 1;
            }
            for (var i = 0; i < board.Length; i++)
            {
                if (IsValid(board, row, i))
                {
                    board[row] = i;
                    result = DFS(result, board, row + 1);
                }
            }
            return result;
        }

        bool IsValid(int[] board, int row, int pos)
        {
            for (var i = 0; i < row; i++)
            {
                if (board[i] == pos || i - board[i] == row - pos || i + board[i] == row + pos)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

namespace LeetCode.Hard.SolveNQueens
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var result = new List<IList<string>>();
            DFS(result, new int[n], 0);
            return result;
        }

        void DFS(IList<IList<string>> result, int[] board, int row)
        {
            if (row == board.Length)
            {
                result.Add(BoardToResult(board));
            }
            for (var col = 0; col < board.Length; col++)
            {
                if (IsValid(board, row, col))
                {
                    board[row] = col;
                    DFS(result, board, row + 1);
                }
            }
        }

        bool IsValid(int[] board, int i, int j)
        {
            for (var x = 0; x < i; x++)
            {
                var y = board[x];
                if (y == j)
                {
                    return false;
                }
                if (x + y == i + j)
                {
                    return false;
                }
                if (x - y == i - j)
                {
                    return false;
                }
            }
            return true;
        }

        IList<string> BoardToResult(int[] board)
        {
            var result = new List<string>();
            for (var i = 0; i < board.Length; i++)
            {
                var charArray = Enumerable.Repeat('.', board.Length).ToArray();
                charArray[board[i]] = 'Q';
                result.Add(new string(charArray));
            }

            return result;
        }
    }
}

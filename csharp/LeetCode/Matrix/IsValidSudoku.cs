namespace LeetCode.Matrix.IsValidSudoku
{
    public class Solution
    {
        int[] squares = new int[9];
        int[] rows = new int[9];
        int[] cols = new int[9];
        public bool IsValidSudoku(char[][] board)
        {
            for (var i = 0; i < 9; i++)
            {
                var x = i / 3;
                for (var j = 0; j < 9; j++)
                {
                    var y = j / 3;
                    // squares
                    if (board[i][j] == '.') continue;
                    var v = 1 << (board[i][j] - 0);
                    if ((squares[x * 3 + y] & v) != 0) return false;
                    squares[x * 3 + y] |= v;
                    // rows
                    if ((rows[i] & v) != 0) return false;
                    rows[i] |= v;
                    // cols
                    if ((cols[j] & v) != 0) return false;
                    cols[j] |= v;
                }
            }
            return true;
        }
    }
}

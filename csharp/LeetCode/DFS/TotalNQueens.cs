namespace LeetCode.DFS.TotalNQueens
{
    public class Solution
    {
        int res;
        int N;
        public int TotalNQueens(int n)
        {
            N = n;
            DFS(new int[n], 0);
            return res;
        }

        void DFS(int[] board, int i)
        {
            if (i == N)
            {
                res++;
                return;
            }

            for (var j = 0; j < N; j++)
            {
                if (Check(board, i, j))
                {
                    board[i] = j;
                    DFS(board, i + 1);
                }
            }
        }

        bool Check(int[] b, int x, int y)
        {
            for (var i = 0; i < x; i++)
            {
                var j = b[i];
                if (j == y || i + j == x + y || i - j == x - y)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

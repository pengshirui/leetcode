namespace LeetCode.DFS.SolveNQueens
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        IList<IList<string>> result = new List<IList<string>>();
        int N;
        public IList<IList<string>> SolveNQueens(int n)
        {
            N = n;
            DFS(new int[n], 0);
            return result;
        }

        void DFS(int[] board, int i)
        {
            if (i == N)
            {
                result.Add(Convert(board));
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

        bool Check(int[] board, int x, int y)
        {
            // Check answer above row: x
            for (var i = 0; i < x; i++)
            {
                var j = board[i];
                if (j == y || i + j == x + y || i - j == x - y)
                {
                    return false;
                }
            }
            return true;
        }


        IList<string> Convert(int[] b)
        {
            var res = new List<string>();
            var dots = new char[N];
            Array.Fill(dots, '.');
            for (var i = 0; i < N; i++)
            {
                dots[b[i]] = 'Q';
                res.Add(new string(dots));
                dots[b[i]] = '.';
            }
            return res;
        }
    }
}

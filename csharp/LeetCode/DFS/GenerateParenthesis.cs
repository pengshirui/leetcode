namespace LeetCode.DFS.GenerateParenthesis
{
    using System.Collections.Generic;

    public class Solution
    {
        IList<string> Result = new List<string>();
        int N;
        public IList<string> GenerateParenthesis(int n)
        {
            N = n;
            DFS(string.Empty, 0, 0);
            return Result;
        }

        void DFS(string res, int open, int close)
        {
            if (open == close && close == N)
            {
                Result.Add(res);
                return;
            }

            // open it;
            if (open + 1 <= N)
            {
                DFS(res + "(", open + 1, close);
            }
            // close if  open is more than close
            if (open > close)
            {
                DFS(res + ")", open, close + 1);
            }
        }
    }
}

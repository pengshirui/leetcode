namespace LeetCode.DFS.CombinationSum3
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        IList<IList<int>> Result = new List<IList<int>>();
        int K;

        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            K = k;
            DFS(new List<int>(), 1, n);
            return Result;
        }

        void DFS(List<int> res, int start, int n)
        {
            if (n == 0)
            {
                if (res.Count != K) return;
                Result.Add(new List<int>(res));
                return;
            }

            for (var i = start; i <= 9; i++)
            {
                if (n - i < 0 || res.Count > K) return;
                res.Add(i);
                DFS(res, i + 1, n - i);
                res.RemoveAt(res.Count - 1);
            }
        }
    }
}

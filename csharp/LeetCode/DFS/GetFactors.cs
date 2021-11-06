namespace LeetCode.DFS.GetFactors
{
    using System.Collections.Generic;

    public class Solution
    {
        IList<IList<int>> Result = new List<IList<int>>();
        int N;
        public IList<IList<int>> GetFactors(int n)
        {
            N = n;
            DFS(new List<int>(), 2, n);
            return Result;
        }

        void DFS(List<int> res, int start, int n)
        {
            if (res.Count >= 2 && n == 1)
            {
                Result.Add(new List<int>(res));
                return;
            }
            for (var i = start; i <= n; i++)
            {
                if (n % i != 0) continue;
                res.Add(i);
                DFS(res, i, n / i);
                res.RemoveAt(res.Count - 1);
            }
        }
    }
}

namespace LeetCode.Medium.Combine
{
    using System.Collections.Generic;

    public class Solution
    {
        List<IList<int>> Result = new List<IList<int>>();
        int N;
        int K;
        public IList<IList<int>> Combine(int n, int k)
        {
            N = n;
            K = k;
            var visited = new bool[N + 1];
            DFS(new List<int>(), 1, visited);
            return Result;
        }

        void DFS(List<int> res, int start, bool[] visited)
        {
            if (res.Count == K)
            {
                Result.Add(new List<int>(res));
                return;
            }

            for (var i = start; i <= N; i++)
            {
                if (visited[i]) continue;
                res.Add(i);
                visited[i] = true;
                DFS(res, i + 1, visited);
                visited[i] = false;
                res.RemoveAt(res.Count - 1);
            }
        }
    }
}

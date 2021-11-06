namespace LeetCode.Medium.NumberOfPatterns
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        private readonly int[,] Skips = new int[10, 10];

        public int NumberOfPatterns(int m, int n)
        {
            Skips[1, 3] = Skips[3, 1] = 2;
            Skips[1, 7] = Skips[7, 1] = 4;
            Skips[3, 9] = Skips[9, 3] = 6;
            Skips[7, 9] = Skips[9, 7] = 8;
            Skips[1, 9] = Skips[9, 1] = Skips[2, 8] = Skips[8, 2] = Skips[3, 7] = Skips[7, 3] = Skips[4, 6] = Skips[6, 4] = 5;

            var visited = new bool[10];
            var result = 0;
            for (var i = m; i <= n; i++)
            {
                result += DFS(visited, 1, i - 1) * 4;
                result += DFS(visited, 2, i - 1) * 4;
                result += DFS(visited, 5, i - 1);
            }
            return result;
        }

        int DFS(bool[] visited, int x, int count)
        {
            visited[x] = true;
            if (count == 0)
            {
                visited[x] = false;
                return 1;
            }

            var result = 0;
            for (var i = 1; i < 10; i++)
            {
                var skip = Skips[x, i];
                if (!visited[i] && (skip == 0 || visited[skip]))
                {
                    result += DFS(visited, i, count - 1);
                }
            }

            visited[x] = false;
            return result;
        }
    }
}

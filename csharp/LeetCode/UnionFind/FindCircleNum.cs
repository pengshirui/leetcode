namespace LeetCode.UnionFind.FindCircleNum
{
    public class Solution
    {
        int[] parent;
        public int FindCircleNum(int[][] isConnected)
        {
            var n = isConnected.Length;
            parent = new int[n];
            for (var i = 0; i < n; i++)
            {
                parent[i] = i;
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (isConnected[i][j] == 1)
                    {
                        // connected
                        var x = Find(i);
                        var y = Find(j);
                        parent[x] = y;
                    }
                }
            }

            var res = 0;
            for (var i = 0; i < n; i++)
            {
                if (i == parent[i]) res++;
            }
            return res;
        }


        int Find(int x)
        {
            while (x != parent[x])
            {
                x = parent[x];
            }
            return x;
        }
    }
}

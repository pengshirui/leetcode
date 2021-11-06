namespace LeetCode.Medium.FindCircleNum
{
    public class Solution
    {
        int[] Parents;
        public int FindCircleNum(int[][] isConnected)
        {
            var n = isConnected.Length;
            var result = n;
            Parents = new int[n];
            for (var i = 0; i < n; i++)
            {
                Parents[i] = i;
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    if (isConnected[i][j] == 1)
                    {
                        if (!Union(i, j))
                        {
                            result--;
                        }
                    }
                }
            }

            return result;
        }

        bool Union(int x, int y)
        {
            var rootX = Find(x);
            var rootY = Find(y);

            Parents[rootX] = rootY;
            return rootX == rootY;
        }

        int Find(int x)
        {
            if (x != Parents[x])
            {
                Parents[x] = Find(Parents[x]);
            }
            return Parents[x];
        }
    }

}

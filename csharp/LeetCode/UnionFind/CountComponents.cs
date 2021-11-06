namespace LeetCode.UnionFind.CountComponents
{
    public class Solution
    {
        int[] p;
        public int CountComponents(int n, int[][] edges)
        {
            p = new int[n];
            for (var i = 0; i < n; i++) p[i] = i;

            foreach (var e in edges)
            {
                var x = Find(e[0]);
                var y = Find(e[1]);
                p[x] = y;
            }

            var res = 0;
            for (var i = 0; i < n; i++)
            {
                if (p[i] == i) res++;
            }
            return res;
        }

        int Find(int x)
        {
            while (x != p[x])
            {
                x = p[x];
            }
            return x;
        }
    }
}

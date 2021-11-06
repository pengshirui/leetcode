namespace LeetCode.Medium
{
    using System.Collections.Generic;

    public partial class Solution
    {
        public int RemoveStones(int[][] stones)
        {
            var row = new Dictionary<int, List<int>>();
            var col = new Dictionary<int, List<int>>();
            for (var i = 0; i < stones.Length; i++)
            {
                var r = stones[i][0];
                var c = stones[i][1];
                row.TryAdd(r, new List<int>());
                row[r].Add(i);
                col.TryAdd(c, new List<int>());
                col[c].Add(i);
            }

            var parent = new int[stones.Length];
            for (var i = 0; i < parent.Length; i++)
            {
                parent[i] = i;
            }
            foreach (var l in row.Values)
            {
                for (var i = 1; i < l.Count; i++)
                {
                    Union(parent, l[i], l[i - 1]);
                }
            }

            foreach (var l in col.Values)
            {
                for (var i = 1; i < l.Count; i++)
                {
                    Union(parent, l[i], l[i - 1]);
                }
            }

            var nroot = 0;
            for (int i = 0; i < stones.Length; i++)
            {
                if (parent[i] == i) nroot++;
            }

            return stones.Length - nroot;
        }

        bool Union(int[] p, int i, int j)
        {
            var rootOfI = Find(p, i);
            var rootOfJ = Find(p, j);

            p[rootOfI] = rootOfJ;
            return rootOfI == rootOfJ;
        }

        int Find(int[] p, int x)
        {
            if (p[x] != x)
            {
                p[x] = Find(p, p[x]);
            }
            return p[x];
        }
    }
}

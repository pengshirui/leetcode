namespace LeetCode.Medium
{
    using LeetCode.DataStructures;

    public partial class Solution
    {
        public int[] FindRedundantConnection2(int[][] edges)
        {
            DSU = new DSU(edges.Length + 1);

            foreach (int[] edge in edges)
            {
                if (DSU.Union(edge[0], edge[1]))
                {
                    return edge;
                }
            }
            return edges[0];
        }
    }
}

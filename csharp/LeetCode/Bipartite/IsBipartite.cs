namespace LeetCode.Bipartite.IsBipartite
{
    public class Solution
    {
        int[][] Graph;
        int[] Colors;
        public bool IsBipartite(int[][] graph)
        {
            if (graph == null) return false;
            Graph = graph;
            Colors = new int[graph.Length];
            for (var i = 0; i < graph.Length; i++)
            {
                if (Colors[i] == 0)
                {
                    if (!DFS(i, 1))
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        bool DFS(int i, int color)
        {
            Colors[i] = color;
            foreach (var n in Graph[i])
            {
                if (Colors[n] == 0)
                {
                    if (!DFS(n, 3 - color))
                    {
                        return false;
                    }

                }
                else if (Colors[n] != 3 - color)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

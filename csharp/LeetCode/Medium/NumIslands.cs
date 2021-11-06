namespace LeetCode.Medium
{
    public partial class Solution
    {

        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            {
                return 0;
            }

            var m = grid.Length;
            var n = grid[0].Length;
            var i = 0;
            var visited = new bool[m, n];
            var count = 0;
            while (i < m)
            {
                var j = 0;
                while (j < n)
                {
                    if (!visited[i, j])
                    {
                        this.Visit(i, j, grid, visited);
                        if (grid[i][j] == '1')
                        {
                            count++;
                        }
                    }
                    j++;
                }
                i++;
            }
            return count;
        }

        private void Visit(int i, int j, char[][] grid, bool[,] visited)
        {
            if (i >= 0 && j >= 0 && i < grid.Length && j < grid[0].Length && !visited[i, j])
            {
                visited[i, j] = true;
                if (grid[i][j] == '1')
                {
                    // go left
                    this.Visit(i, j - 1, grid, visited);
                    // go right
                    this.Visit(i, j + 1, grid, visited);
                    // go up
                    this.Visit(i - 1, j, grid, visited);
                    // go bottom
                    this.Visit(i + 1, j, grid, visited);
                }
                // not a land
            }
        }
    }
}

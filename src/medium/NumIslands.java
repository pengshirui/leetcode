package medium;

/**
 * https://leetcode.com/problems/number-of-islands/solution/
 */
public class NumIslands {
    public int NumIslands(char[][] grid) {
        int islandCount = 0;
        int rowLen = grid.length;
        if(rowLen < 1) {
            return 0;
        }
        int colLen = grid[0].length;
        for (int i=0; i<rowLen; i++){
            for (int j=0; j<colLen; j++){
                if(grid[i][j] == '1') {
                    ++islandCount;
                    dfs(grid, i, j);
                }
            }
        }
        return islandCount;
    }

    private void dfs(char[][] grid, int i, int j){
        // mark visited point to 0
        grid[i][j] = 0;
        //check left
        if (j-1>= 0 && grid[i][j-1] == '1'){
            dfs(grid, i, j-1);
        }
        //check right
        if (j+1<grid[0].length && grid[i][j+1] == '1'){
            dfs(grid, i, j+1);
        }
        //check top
        if (i-1>=0 && grid[i-1][j] == '1'){
            dfs(grid, i-1, j);
        }
        //check bottom
        if (i+1< grid.length && grid[i+1][j] == '1'){
            dfs(grid, i+1, j);
        }

    }
}

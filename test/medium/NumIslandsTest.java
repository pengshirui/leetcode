package medium;

import org.junit.Assert;
import org.junit.Test;

public class NumIslandsTest {

    @Test
    public void Test(){
        NumIslands numIslands = new NumIslands();
        char[][] grid = {{'1', '0', '0'}, {'1', '0', '1'}};

        int res = numIslands.NumIslands(grid);

        Assert.assertEquals(2, res);
    }
}

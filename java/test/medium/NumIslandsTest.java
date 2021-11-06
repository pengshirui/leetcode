package medium;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class NumIslandsTest {

    @Test
    public void Test(){
        NumIslands numIslands = new NumIslands();
        char[][] grid = {{'1', '0', '0'}, {'1', '0', '1'}};

        int res = numIslands.NumIslands(grid);

        Assertions.assertEquals(2, res);
    }
}

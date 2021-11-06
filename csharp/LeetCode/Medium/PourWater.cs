namespace LeetCode.Medium.PourWater
{
    public class Solution
    {
        public int[] PourWater(int[] heights, int volume, int k)
        {
            while (volume-- > 0)
            {
                var c = k;
                while (c > 0 && heights[c - 1] <= heights[c])
                {
                    c--;
                }

                while (c < heights.Length - 1 && heights[c ] >= heights[c + 1])
                {
                    c++;
                }
                
                while (c > k && heights[c - 1] == heights[c])
                {
                    c--;
                }
                heights[c]++;
            }
            return heights;
        }
    }
}

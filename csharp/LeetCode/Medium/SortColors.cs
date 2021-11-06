namespace LeetCode.Medium.SortColors
{
    public class Solution
    {
        public void SortColors(int[] nums)
        {
            var counts = new int[3];
            foreach (var n in nums)
            {
                counts[n]++;
            }
            var k = 0;
            for (var i = 0; i < counts.Length; i++)
            {
                for (var j = 0; j < counts[i]; j++)
                {
                    nums[k++] = i;
                }
            }
        }
    }
}

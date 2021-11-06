namespace LeetCode.Easy
{
    public partial class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            var j = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (i != nums.Length - 1 && nums[i] == nums[i + 1])
                {
                    continue;
                }
                if (j < nums.Length)
                {
                    nums[j++] = nums[i];
                }
            }
            return j;
        }
    }
}

namespace LeetCode.Easy
{
    public partial class Solution
    {
        public int MissingNumber(int[] nums)
        {
            var ans = (nums.Length * nums.Length - nums.Length) / 2;
            foreach (var n in nums)
            {
                ans -= n;
            }

            return ans;
        }
    }
}

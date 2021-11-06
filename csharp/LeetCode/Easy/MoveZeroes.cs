namespace LeetCode.Easy
{
    public partial class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums == null)
            {
                return;
            }

            var left = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (left != i)
                    {
                        nums[left] = nums[i];
                        nums[i] = 0;
                    }

                    left++;
                }
            }
        }
    }
}

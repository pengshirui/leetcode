namespace LeetCode.Medium.Jump
{
    using System;

    public class Solution
    {
        public int Jump(params int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return 0;
            }

            int jump = 0, farthest = 0, currentJumpEnd = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                farthest = Math.Max(farthest, i + nums[i]);

                if (i == currentJumpEnd)
                {
                    jump++;
                    currentJumpEnd = farthest;
                }
            }

            return jump;
        }
    }
}

namespace LeetCode.Medium.NextPermutation
{
    public class Solution
    {
        public void NextPermutation(int[] nums)
        {
            // second last number
            var i = nums.Length - 2;
            while (i >= 0 && nums[i] > nums[i + 1])
            {
                i--;
            }
            if (i >= 0)
            {
                var num1 = nums[i];
                var j = nums.Length - 1;
                while (nums[j] <= num1)
                {
                    j--;
                }
                Swap1(nums, i, j);
            }

            Reverse(nums, i + 1);
        }

        void Swap1(int[] nums, int i, int j)
        {
            var t = nums[i];
            nums[i] = nums[j];
            nums[j] = t;
        }

        void Reverse(int[] nums, int start)
        {
            var i = start;
            var j = nums.Length - 1;
            while (i < j)
            {
                Swap1(nums, i, j);
                i++;
                j--;
            }
        }
    }
}

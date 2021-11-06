namespace LeetCode.Medium.ProductExceptSelf
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            result[0] = 1;
            var product = 1;
            for (var i = 1; i < nums.Length; i++)
            {
                product *= nums[i - 1];
                if (product == 0)
                {
                    break;
                }
                result[i] = product;
            }
            product = 1;
            for (var i = nums.Length - 2; i >= 0; i--)
            {
                product *= nums[i + 1];
                result[i] *= product;
            }
            return result;
        }
    }
}

namespace LeetCode.Easy
{
    using System;

    public partial class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            var plusOne = 1;
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                var sum = digits[i] + plusOne;
                plusOne = sum / 10;
                digits[i] = sum % 10;
            }

            if (plusOne == 1)
            {
                var result = new int[digits.Length + 1];
                result[0] = 1;
                Array.Copy(digits, 0, result, 1, digits.Length);
                return result;
            }
            return digits;
        }
    }
}

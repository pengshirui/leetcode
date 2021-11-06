namespace LeetCode.Medium
{
    using System;

    public partial class Solution
    {
        public int MaxTurbulenceSize(params int[] arr)
        {
            if (arr.Length < 2)
            {
                return arr.Length;
            }
            var increase = arr[0] > arr[1];
            var count = arr[0] == arr[1] ? 1 : 2;
            var ans = count;
            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    count = 1;
                }
                else if (increase == (arr[i] > arr[i - 1]))
                {
                    count++;
                    ans = Math.Max(ans, count);
                }
                else
                {
                    count = 2;
                }
                increase = arr[i - 1] > arr[i];
            }

            return ans;
        }
    }
}

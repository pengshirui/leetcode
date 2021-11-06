namespace LeetCode.Hard.SplitArray
{
    using System;
    using System.Linq;

    public class Solution
    {
        int[] SubSum;
        int[,] Memo;

        public int SplitArray(int[] nums, int m)
        {
            SubSum = new int[nums.Length + 1];
            Memo = new int[nums.Length + 1, m + 1];
            for (var i = 0; i < nums.Length; i++)
            {
                SubSum[i + 1] = SubSum[i] + nums[i];
            }
            return SplitArrayInternal(nums, 0, m);
        }

        int SplitArrayInternal(int[] nums, int start, int m)
        {
            if (m == 1)
            {
                return SubSum[nums.Length] - SubSum[start];
            }

            if (Memo[start, m] != 0)
            {
                return Memo[start, m];
            }

            var result = int.MaxValue;
            for (var i = start; i < nums.Length; i++)
            {
                var sum1 = SubSum[i + 1] - SubSum[start];
                var sum2 = SplitArrayInternal(nums, i + 1, m - 1);

                var sum = Math.Max(sum1, sum2);
                result = Math.Min(result, sum);
            }
            return Memo[start, m] = result;
        }

        public int SplitArray2(int[] nums, int m)
        {
            var l = nums.Max();
            var r = nums.Sum();
            while (l <= r)
            {
                var subSum = l + (r - l) / 2;
                if (IsValid(nums, subSum, m))
                {
                    // can fit more
                    r = subSum - 1;
                }
                else
                {
                    l = subSum + 1;
                }
            }
            return l;
        }

        bool IsValid(int[] nums, int target, int m)
        {
            int count = 1;
            long total = 0;
            foreach (int num in nums)
            {
                total += num;
                if (total > target)
                {
                    total = num;
                    count++;
                    if (count > m)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public int[] SumEvenAfterQueries(int[] nums, int[][] queries)
        {
            var ans = new int[nums.Length];
            var sum = 0;
            foreach (var n in nums)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }
            for (var i = 0; i < queries.Length; i++)
            {
                if (queries[i].Length != 2)
                {
                    continue;
                }
                var delta = queries[i][0];
                var index = queries[i][1];

                if (nums[index] % 2 == 0)
                {
                    sum -= nums[index];
                }
                var newVal = delta + nums[index];
                if (newVal % 2 == 0)
                {
                    sum += newVal;
                }
                ans[i] = sum;
                nums[index] = newVal;
            }

            return ans;
        }
    }
}

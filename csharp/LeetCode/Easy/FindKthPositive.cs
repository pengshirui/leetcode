namespace LeetCode.Easy
{
    public partial class Solution
    {
        public int FindKthPositive(int[] arr, int k)
        {
            var l = 0;
            var r = arr.Length;
            while (l < r)
            {
                var m = l / 2 + r / 2;
                var miss = arr[m] - m - 1;
                if (miss >= k)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }

            return r + k;
        }
    }
}

﻿namespace LeetCode.Sort.FindKthLargest
{
    public class Solution
    {
        int[] Nums;
        public int FindKthLargest(int[] nums, int k)
        {
            Nums = nums;
            return QuickSelect(0, nums.Length - 1, nums.Length - k);
        }

        int QuickSelect(int l, int r, int k)
        {
            if (l == r) return Nums[k];

            var i = l - 1;
            var j = r + 1;
            var m = Nums[l];
            while (i < j)
            {
                do
                {
                    i++;
                }
                while (Nums[i] < m);

                do
                {
                    j--;
                }
                while (Nums[j] > m);

                if (i < j)
                {
                    var t = Nums[i];
                    Nums[i] = Nums[j];
                    Nums[j] = t;
                }
            }
            if (k <= j)
            {
                return QuickSelect(l, j, k);
            }
            else
            {
                return QuickSelect(j + 1, r, k);
            }
        }
    }
}

namespace LeetCode.Medium
{
    using System;
    using System.Collections.Generic;

    public partial class Solution
    {
        public int TotalFruit(int[] tree)
        {
            var basket = new Dictionary<int, int>();
            var l = 0;
            var r = 0;
            var ans = 0;
            var count = 0;
            while (r < tree.Length)
            {
                basket[tree[r]] = basket.GetValueOrDefault(tree[r], 0) + 1;
                count++;
                while (basket.Keys.Count > 2)
                {
                    basket[tree[l]] = basket.GetValueOrDefault(tree[l], 0) - 1;
                    count--;
                    if (basket[tree[l]] == 0)
                    {
                        basket.Remove(tree[l]);
                    }
                    l++;
                }
                ans = Math.Max(count, ans);
                r++;
            }
            return ans;
        }
    }
}

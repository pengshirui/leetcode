using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            var ans = new List<int[]>();
            var i = 0;
            var j = 0;
            while (i < firstList.Length && j < secondList.Length)
            {
                var first = firstList[i];
                var l1 = first[0];
                var r1 = first[1];
                var second = secondList[j];
                var l2 = second[0];
                var r2 = second[1];

                var left = Math.Max(l1, l2);
                var right = Math.Min(r1, r2);
                if (left <= right)
                {
                    ans.Add(new int[] { left, right });
                }

                if (r1 > r2)
                {
                    j++;
                }
                else if (r1 < r2)
                {
                    i++;
                }
                else
                {
                    i++;
                    j++;
                }
            }
            return ans.ToArray();
        }
    }
}

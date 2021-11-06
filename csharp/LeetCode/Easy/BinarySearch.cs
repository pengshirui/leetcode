namespace LeetCode.Easy.BinarySearch
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        // [1, 2, 4] -> 3 
        // returns index 1 (2)
        public int LowerBound(IList<int> list, int k)
        {
            var l = 0;
            var r = list.Count - 1;
            while (l + 1 < r)
            {
                var m = (l + r) / 2;
                if (list[m] > k)
                {
                    r = m - 1;
                }
                else if (list[m] < k)
                {
                    l = m;
                }
                else
                {
                    r = m;
                }
            }
            if (k < list[l]) return -1;
            if (k == list[l]) return l;
            if (k < list[r]) return l;
            return r;
        }

        // [1, 2, 4] -> 3 
        // returns index 3 (4)
        public int UpperBound(IList<int> list, int k)
        {
            var l = 0;
            var r = list.Count - 1;
            while (l <= r)
            {
                var m = (l + r) / 2;
                var middle = list[m];
                if (middle == k)
                {
                    return m;
                }
                else if (middle < k)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }
            return l;
        }
    }
}

namespace LeetCode.BinarySearch.BinarySearch
{
    using System.Collections.Generic;

    public class Solution
    {
        // [1, 2, 4] -> 3 
        // returns index 1 (2)
        public int LowerBound(IList<int> list, int k)
        {
            var l = 0;
            var r = list.Count - 1;
            while (l < r)
            {
                var m = l + r  + 1 >> 1;
                if (list[m] < k)
                {
                    l = m;
                }
                else
                {
                    r = m - 1;
                }
            }
            return l;
        }

        // [1, 2, 4] -> 3 
        // returns index 3 (4)
        public int UpperBound(IList<int> list, int k)
        {
            var l = 0;
            var r = list.Count - 1;
            while (l < r)
            {
                var m = l + r >> 1;
                if (list[m] < k)
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

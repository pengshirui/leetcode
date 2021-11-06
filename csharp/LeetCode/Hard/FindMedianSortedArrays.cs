namespace LeetCode.Hard.FindMedianSortedArrays
{
    using System;

    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                // make sure first one is shorter
                return FindMedianSortedArrays(nums2, nums1);
            }
            // Need m elements in the first half of sorted arrays
            var m = (nums1.Length + nums2.Length) / 2;
            var l1 = 0;
            var r1 = nums1.Length - 1; // set to last item.
            while (true)
            {
                int m1 = r1 == -1 ? r1 : (l1 + r1) / 2;
                var m2 = m - m1 - 2; // get the index of the second array
                var mid1 = m1 >= 0 ? nums1[m1] : int.MinValue;
                var mid1Right = m1 + 1 < nums1.Length ? nums1[m1 + 1] : int.MaxValue;
                var mid2 = m2 >= 0 ? nums2[m2] : int.MinValue;
                var mid2Right = m2 + 1 < nums2.Length ? nums2[m2 + 1] : int.MaxValue;
                if (mid1 <= mid2Right && mid2 <= mid1Right)
                {
                    if ((nums1.Length + nums2.Length) % 2 == 0)
                    {
                        return (Math.Max(mid1, mid2) + Math.Min(mid1Right, mid2Right)) / 2.0;
                    }
                    else
                    {
                        return Math.Min(mid1Right, mid2Right);
                    }
                }
                else if (mid1 > mid2Right)
                {
                    r1 = m1 - 1;
                }
                else
                {
                    l1 = m1 + 1;
                }
            }
        }
    }
}

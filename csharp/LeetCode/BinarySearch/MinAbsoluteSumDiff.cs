namespace LeetCode.BinarySearch.MinAbsoluteSumDiff
{
    using System;

    public class Solution
    {
        const int M = (int)1e9 + 7;
        public int MinAbsoluteSumDiff(int[] nums1, int[] nums2)
        {
            long ps = 0;
            for (var i = 0; i < nums1.Length; i++)
            {
                ps += Math.Abs(nums1[i] - nums2[i]);
            }

            var sorted = new int[nums1.Length];
            Array.Copy(nums1, sorted, nums1.Length);
            Array.Sort(sorted);
            var d = 0;
            for (var i = 0; i < nums1.Length; i++)
            {
                var d0 = Math.Abs(nums1[i] - nums2[i]);
                if (d0 == 0) continue;
                var d1 = Math.Abs(Find(sorted, nums2[i]) - nums2[i]);
                d = Math.Max(d, Math.Abs(d0 - d1));
            }

            return (int)((ps - d) % M);
        }

        int Find(int[] arr, int k)
        {
            var l = 0;
            var r = arr.Length - 1;
            var d = int.MaxValue;
            while (l + 1 < r)
            {
                var m = l + r >> 1;
                if (arr[m] < k)
                {
                    if (k - arr[m] < d)
                    {
                        l = m;
                        d = k - arr[m];
                    }
                    else
                    {
                        l = m + 1;
                    }
                }
                else if (k < arr[m])
                {
                    if (arr[m] - k < d)
                    {
                        r = m;
                        d = arr[m] - k;
                    }
                    else
                    {
                        r = m - 1;
                    }
                }
                else if (k == arr[m])
                {
                    return k;
                }
            }
            return k - arr[l] < arr[r] - k ? arr[l] : arr[r];
        }
    }
}

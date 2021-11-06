namespace LeetCode.Easy
{
    using System.Collections.Generic;

    public partial class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var dictionary = new Dictionary<int, int>();
            foreach (var num in nums1)
            {
                if (dictionary.TryGetValue(num, out var val))
                {
                    val++;
                    dictionary[num] = val;
                }
                else
                {
                    dictionary[num] = 1;
                }
            }

            var result = new List<int>();
            foreach (var num in nums2)
            {
                if (dictionary.TryGetValue(num, out var val))
                {
                    if (val > 0)
                    {
                        val--;
                        dictionary[num] = val;
                        result.Add(num);
                    }
                }
            }
            return result.ToArray();
        }
    }
}

namespace LeetCode.Hard.MaxSlidingWindow
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var result = new List<int>();
            var link = new LinkedList<int>();
            for (var i = 0; i <= nums.Length; i++)
            {
                while (link.Any() && link.First.Value + k < i)
                {
                    link.RemoveFirst();
                }
                if (i >= k)
                {
                    result.Add(nums[link.First.Value]);
                }
                if (i == nums.Length) break;

                var num = nums[i];
                while (link.Any() && nums[link.Last.Value] < num)
                {
                    link.RemoveLast();
                }
                link.AddLast(i);
            }
            return result.ToArray();
        }
    }
}

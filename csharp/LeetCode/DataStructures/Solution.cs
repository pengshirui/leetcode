namespace LeetCode.DataStructures.Solution
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        private readonly int[] Origin;
        private readonly Random Ran = new Random();
        public Solution(int[] nums)
        {
            Origin = nums;
        }

        public int[] Reset()
        {
            return Origin;
        }

        public int[] Shuffle()
        {
            var res = new int[Origin.Length];
            Array.Copy(Origin, res, Origin.Length);
            for (int i = 0; i < res.Length; i++)
            {
                int j = Ran.Next(Origin.Length);

                int t = res[i];
                res[i] = res[j];
                res[j] = t;
            }
            return res;
        }
    }
}

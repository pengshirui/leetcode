namespace LeetCode.DFS.CombinationSum4
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        int[] Nums;
        int Result;
        int[] DP;
        public int CombinationSum4(int[] nums, int target)
        {
            Nums = nums;
            Array.Sort(Nums);
            DFS(target);
            return Result;
        }

        void DFS(int target)
        {
            if (target == 0)
            {
                Result++;
                return;
            }
            for (var i = 0; i < Nums.Length; i++)
            {
                var t = Nums[i];
                if (target - t < 0) return;
                DFS(target - t);
            }
        }
        public int CombinationSum4DP(int[] nums, int target)
        {
            Nums = nums;
            Array.Sort(Nums);
            DP = new int[target + 1];
            Array.Fill(DP, -1);
            DP[0] = 1;
            return DFSDP(target);
        }

        int DFSDP(int target)
        {
            if (DP[target] != -1) return DP[target];
            var res = 0;
            for (var i = 0; i < Nums.Length; i++)
            {
                var t = Nums[i];
                if (target - t < 0) break;
                res += DFSDP(target - t);
            }
            DP[target] = res;
            return res;
        }
    }
}

namespace LeetCode.DFS.CombinationSum
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        IList<IList<int>> Result = new List<IList<int>>();
        int[] Can;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            Can = candidates;
            DFS(new List<int>(), 0, target);
            return Result;
        }

        void DFS(IList<int> res, int start, int target)
        {
            if (target == 0)
            {
                Result.Add(new List<int>(res));
                return;
            }

            for (var i = start; i < Can.Length; i++)
            {
                var item = Can[i];
                if (target - item < 0) return;
                // take this one
                res.Add(item);
                DFS(res, i, target - item);
                res.RemoveAt(res.Count - 1);
            }
        }
    }
}

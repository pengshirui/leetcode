namespace LeetCode.DFS.CombinationSum2
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        IList<IList<int>> Result = new List<IList<int>>();
        int[] Can;
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Can = candidates;
            Array.Sort(Can);
            DFS(new List<int>(), 0, target);
            return Result;
        }

        void DFS(List<int> res, int start, int target)
        {
            if (target == 0)
            {
                Result.Add(new List<int>(res));
                return;
            }

            for (var i = start; i < Can.Length; i++)
            {
                var t = Can[i];
                if (i > start && t == Can[i - 1]) continue;
                if (target - t < 0) continue;
                //add
                res.Add(t);
                // DFS
                DFS(res, i + 1, target - t);
                //remove
                res.RemoveAt(res.Count - 1);
            }
        }
    }
}

namespace LeetCode.Hard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solution
    {
        public double MincostToHireWorkers(int[] quality, int[] wage, int k)
        {
            var workers = new (int, int)[quality.Length];
            for (var i = 0; i < quality.Length; i++)
            {
                workers[i] = (quality[i], wage[i]);
            }

            Array.Sort(workers, (a, b) => ((double)a.Item2 / (double)a.Item1).CompareTo((double)b.Item2 / (double)b.Item1));

            var ans = double.MaxValue;
            var memo = new int[quality.Length];
            var desc = Comparer<int>.Create((x, y) => y - x);
            var heap = new SortedList<int, int>(desc);
            var count = 0;
            var totalQuality = 0;
            for (var j = 0; j < quality.Length; j++)
            {
                var q = heap.GetValueOrDefault(workers[j].Item1, 0) + 1;
                heap[workers[j].Item1] = q;
                totalQuality += workers[j].Item1;
                count++;
                if (count > k)
                {
                    var top = heap.First();
                    var key = top.Key;
                    var val = top.Value - 1;
                    if (val == 0)
                    {
                        heap.Remove(key);
                    }
                    else
                    {
                        heap[key] = val;
                    }
                    totalQuality -= key;
                    count--;
                }
                if (count == k)
                {
                    memo[j] = totalQuality;
                }
            }
            for (var j = workers.Length - 1; j >= k - 1; j--)
            {
                double unitWage = (double)workers[j].Item2 / (double)workers[j].Item1;
                ans = Math.Min(ans, unitWage * memo[j]);
            }

            return ans;
        }
    }
}

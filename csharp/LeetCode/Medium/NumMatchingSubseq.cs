namespace LeetCode.Medium.NumMatchingSubseq
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public int NumMatchingSubseq(string s, string[] words)
        {
            var result = 0;
            var starts = new List<int>[26];
            for (var i = 0; i < s.Length; i++)
            {
                var k = s[i] - 'a';
                if (starts[k] == null)
                {
                    starts[k] = new List<int>();
                }
                starts[k].Add(i);
            }
            foreach (var w in words)
            {
                if (IsSubseq(starts, w))
                {
                    result++;
                }
            }
            return result;
        }

        bool IsSubseq(List<int>[] starts, string w)
        {
            var k = -1;
            for (var i = 0; i < w.Length; i++)
            {
                var list = starts[w[i] - 'a'];
                k = GetIndex(list, k + 1);
                if (k == -1)
                {
                    return false;
                }
            }
            return true;

        }

        int GetIndex(List<int> list, int target)
        {
            if (list == null || target > list.Last()) return -1;
            var l = 0;
            var r = list.Count;
            while (l < r)
            {
                var m = (l + r) / 2;
                var middle = list[m];
                if (middle == target)
                {
                    return middle;
                }
                else if (middle > target)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }
            return list[l];
        }
    }
}

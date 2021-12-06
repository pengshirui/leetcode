namespace LeetCode.DFS.JudgePoint24
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        public bool JudgePoint24(params int[] cards)
        {
            var list = new List<double>();
            foreach (var c in cards) list.Add(c);

            return DFS(list);
        }
        bool DFS(List<double> res)
        {
            if (res.Count == 1)
            {
                if (Math.Abs(res[0] - 24) < 0.001) return true;
                return false;
            }

            for (var i = 0; i < res.Count; i++)
            {
                for (var j = i + 1; j < res.Count; j++)
                {
                    foreach (var d in GetMore(res[i], res[j]))
                    {
                        var next = new List<double>
                        {
                            d
                        };
                        for (var k = 0; k < res.Count; k++)
                        {
                            if (k == j || k == i) continue;
                            next.Add(res[k]);
                        }
                        if (DFS(next)) return true;
                    }
                }
            }
            return false;
        }

        List<double> GetMore(double l, double r)
        {
            var list = new List<double>();
            list.Add(l + r);
            list.Add(Math.Abs(l - r));
            list.Add(l * r);
            list.Add(l / r);
            list.Add(r / l);

            return list;
        }
    }
}

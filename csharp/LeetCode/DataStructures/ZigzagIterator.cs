namespace LeetCode.DataStructures
{
    using System;
    using System.Collections.Generic;

    public class ZigzagIterator
    {
        const int N = 2010;
        int[] q = new int[N];
        int n;
        int hh = 0;
        int tt = -1;
        public ZigzagIterator(IList<int> v1, IList<int> v2)
        {
            n = v1.Count + v2.Count;
            var i = 0;
            var count = Math.Min(v1.Count, v2.Count);
            for (; i < count; i++)
            {
                q[++tt] = v1[i];
                q[++tt] = v2[i];
            }
            while (i < v1.Count)
            {
                q[++tt] = v1[i++];
            }
            while (i < v2.Count)
            {
                q[++tt] = v2[i++];
            }
        }

        public bool HasNext()
        {
            return hh <= tt;
        }

        public int Next()
        {
            if (HasNext())
            {
                return q[hh++];
            }
            return -1;
        }
    }
}

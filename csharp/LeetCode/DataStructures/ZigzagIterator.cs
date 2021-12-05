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
            n = Math.Max(v1.Count, v2.Count);
            for (var i = 0; i < n; i++)
            {
                if (i < v1.Count)
                    q[++tt] = v1[i]; 
                if (i < v2.Count)
                    q[++tt] = v2[i];
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

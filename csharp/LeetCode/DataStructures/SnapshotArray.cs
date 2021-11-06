namespace LeetCode.DataStructures
{
    using System;
    using System.Collections.Generic;

    public class SnapshotArray
    {
        private SortedList<int, int>[] SL;
        private int SnapId = 0;
        public SnapshotArray(int length)
        {
            SL = new SortedList<int, int>[length];
            for (var i = 0; i < length; i++)
            {
                SL[i] = new SortedList<int, int> { { 0, 0 } };
            }
        }

        public void Set(int index, int val)
        {
            SL[index][SnapId] = val;
        }

        public int Snap()
        {
            return SnapId++;
        }

        public int Get(int index, int snap_id)
        {
            if (index >= SL.Length || snap_id < 0 || snap_id >= SnapId) throw new Exception();

            var d = SL[index].Keys;
            var i = d[Search(d, snap_id)];

            return SL[index][i];
        }

        int Search(IList<int> list, int k)
        {
            var l = 0;
            var r = list.Count - 1;
            if (k < list[l]) return -1;
            if (list[r] <= k) return r;
            while (l + 1 < r)
            {
                var m = (l + r) / 2;
                if (list[m] > k)
                {
                    r = m - 1;
                }
                else if (list[m] < k)
                {
                    l = m;
                }
                else
                {
                    r = m;
                }
            }
            return list[r] <= k ? r : l;
        }
    }
}

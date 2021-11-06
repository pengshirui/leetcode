namespace LeetCode.DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class FenwickTree
    {
        private readonly int size;
        private readonly int[] tree;
        private readonly int offset;

        public FenwickTree(int size, int offset)
        {
            this.size = size;
            this.tree = new int[size + 1];
            this.offset = offset;
        }

        public int Query(int index)
        {
            index += offset;
            int sum = 0;
            while (index > 0)
            {
                sum += tree[index];
                index -= index & -index;
            }
            return sum;
        }

        public void Update(int index, int val)
        {
            index = 1 + index + offset;     // skip first index + offset
            while (index < tree.Length)
            {
                tree[index] += val;
                index += index & -index;    // parent index
            }
        }
    }
}

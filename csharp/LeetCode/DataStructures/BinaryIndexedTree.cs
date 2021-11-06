namespace LeetCode.DataStructures
{
    public class BinaryIndexedTree
    {
        private readonly int[] PreSum;
        private readonly int[] Arr;
        private readonly int N;
        public BinaryIndexedTree(int n)
        {
            PreSum = new int[n + 1];
            Arr = new int[n];
            N = n;
        }

        public void Update(int i, int val)
        {
            var delta = val - Arr[i];
            Arr[i] = val;
            i++;
            while (i < PreSum.Length)
            {
                PreSum[i] += delta;
                i += i & -i;
            }
        }

        public int Query(int i, int j)
        {
            return Query(j) - Query(i - 1);
        }

        public int Query(int i)
        {
            var sum = 0;
            i++;
            while (i > 0)
            {
                sum += PreSum[i];
                i -= i & -i;
            }
            return sum;
        }
    }
}

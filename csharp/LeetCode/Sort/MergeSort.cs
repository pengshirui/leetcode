namespace LeetCode.Sort.MergeSort
{
    public class Solution
    {
        int[] Nums;
        int[] T;
        public void MergeSort(int[] nums)
        {
            if (nums == null || nums.Length < 2) return;
            Nums = nums;
            T = new int[Nums.Length];
            MergeSort(0, nums.Length - 1);
        }

        void MergeSort(int l, int r)
        {

            if (l >= r) return;
            var m = l + r >> 1;
            MergeSort(l, m);
            MergeSort(m + 1, r);

            var i = l;
            var j = m + 1;
            var k = 0;
            while (i <= m && j <= r)
            {
                if (Nums[i] <= Nums[j])
                {
                    T[k++] = Nums[i++];
                }
                else
                {
                    T[k++] = Nums[j++];
                }
            }

            while (i <= m) T[k++] = Nums[i++];
            while (j <= r) T[k++] = Nums[j++];
            i = l;
            var a = 0;
            for (; i <= r; a++, i++)
            {
                Nums[i] = T[a];
            }
        }
    }
}

namespace LeetCode.Sort.QuickSort
{
    public class Solution
    {
        int[] Nums;
        public void QuickSort(int[] nums)
        {
            if (nums == null || nums.Length == 0) return;
            Nums = nums;
            Sort(0, nums.Length - 1, 0);
        }

        void Sort(int l, int r, int k)
        {
            if (l >= r) return;
            var i = l - 1;
            var j = r + 1;
            while (i < j)
            {
                do
                {
                    i++;
                }
                while (Nums[i] < Nums[k]);

                do
                {
                    j--;
                }
                while (Nums[j] > Nums[k]);

                if (i < j)
                {
                    var t = Nums[i];
                    Nums[i] = Nums[j];
                    Nums[j] = t;
                }
            }

            Sort(l, j, l);
            Sort(j + 1, r, j + 1);
        }
    }
}

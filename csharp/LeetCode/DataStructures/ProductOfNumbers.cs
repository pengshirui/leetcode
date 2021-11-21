namespace LeetCode.DataStructures
{
    public class ProductOfNumbers
    {
        const int N = (int)4e4 + 10;
        int cnt = 1;
        int[] arr = new int[N];

        public ProductOfNumbers()
        {
            arr[0] = 1;
        }

        public void Add(int num)
        {
            if (num == 0)
            {
                cnt = 1;
            }
            else
            {
                arr[cnt] = arr[cnt - 1] * num;
                cnt++;
            }
        }

        public int GetProduct(int k)
        {
            return cnt - k - 1 < 0 ? 0 : arr[cnt - 1] / arr[cnt - k - 1];
        }
    }
}

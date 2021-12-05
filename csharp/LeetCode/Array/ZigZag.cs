namespace LeetCode.Array.ZigZag
{
    public class Solution
    {
        public bool[] ZigZag(params int[] arr)
        {
            if (arr.Length - 2 < 0) return new bool[0];
            var res = new bool[arr.Length - 2];

            for (var i = 1; i < arr.Length - 1; i++)
            {
                res[i - 1] = (arr[i - 1] < arr[i] && arr[i] > arr[i + 1])
                    || (arr[i - 1] > arr[i] && arr[i] < arr[i + 1]);
            }
            return res;
        }
    }
}

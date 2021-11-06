namespace LeetCode.Medium.MaximumSwap
{
    public class Solution
    {
        public int MaximumSwap(int num)
        {
            var numbers = num.ToString().ToCharArray();

            var i = 1;
            // stop at the first acsending number
            while (i < numbers.Length && numbers[i - 1] >= numbers[i])
            {
                i++;
            }
            if (i == numbers.Length)
            {
                return num;
            }
            var right = i;
            var mid = i;
            // find the right most largest number and its index
            while (i < numbers.Length)
            {
                right = numbers[i] >= numbers[right] ? i : right;
                i++;
            }
            // find the first number less than largest
            var left = 0;
            for (; left < mid; left++)
            {
                if (numbers[left] < numbers[right])
                {
                    break;
                }
            }

            var t = numbers[left];
            numbers[left] = numbers[right];
            numbers[right] = t;
            return int.Parse(new string(numbers));
        }
    }
}

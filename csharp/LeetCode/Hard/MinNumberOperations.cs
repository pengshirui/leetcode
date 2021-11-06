namespace LeetCode.Hard.MinNumberOperations
{
    public class Solution
    {
        public int MinNumberOperations(int[] target)
        {
            if (target == null || target.Length < 1)
                return 0;
            var result = target[0];
            for (var i = 1; i < target.Length; i++)
            {
                // increase for free
                if (target[i] <= target[i - 1])
                {
                    continue;
                }
                else
                {
                    result += target[i] - target[i - 1];
                }
            }
            return result;
        }
    }
}

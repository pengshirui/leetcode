namespace LeetCode.Medium.MaxScore
{
    using System;
    using System.Linq;

    public class Solution
    {
        public int MaxScore(int[] cardPoints, int k)
        {
            if (cardPoints == null || cardPoints.Length == 0) return 0;
            if (k >= cardPoints.Length) return cardPoints.Sum();

            var lefts = new int[k + 1];
            for (var i = 1; i <= k; i++)
            {
                lefts[i] = lefts[i - 1] + cardPoints[i - 1];
            }
            var rights = new int[k + 1];
            for (var i = 1; i <= k; i++)
            {
                var j = cardPoints.Length - i;
                rights[k - i] = rights[k - i + 1] + cardPoints[j];
            }
            var result = 0;
            for (var i = 0; i <= k; i++)
            {
                result = Math.Max(lefts[i] + rights[i], result);
            }
            return result;
        }
    }
}

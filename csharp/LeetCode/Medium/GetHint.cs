/// <summary>
/// https://leetcode.com/problems/bulls-and-cows/
/// </summary>

using System;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public string GetHint(string secret, string guess)
        {
            var bull = 0;
            var cow = 0;
            var sCount = this.GetCount(secret);
            var gCount = this.GetCount(guess);

            for (var i = 0; i < secret.Length; i++)
            {
                if (secret[i] == guess[i])
                {
                    bull++;
                }
            }

            for (var i = 0; i < 10; i++)
            {
                cow += Math.Min(sCount[i], gCount[i]);
            }

            return string.Format("{0}A{1}B", bull, cow - bull);
        }

        private int[] GetCount(string secret)
        {
            var count = new int[10];
            for (var i = 0; i < secret.Length; i++)
            {
                count[secret[i] - '0']++;
            }
            return count;
        }
    }
}

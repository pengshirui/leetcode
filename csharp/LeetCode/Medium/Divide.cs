using System;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1)
            {
                return int.MaxValue;
            }

            var isPositive = divisor > 0 && dividend > 0 || divisor < 0 && dividend < 0;
            var newDividend = dividend > 0 ? -dividend : dividend;
            var newDivisor = divisor > 0 ? -divisor : divisor;
            if (newDivisor < newDividend)
            {
                return 0;
            }
            var current = newDivisor;
            var quotient = 1;
            while (current << 1 < 0 && current << 1 >= newDividend)
            {
                quotient <<= 1;
                current <<= 1;
            }
            var remainder = newDividend - current;
            var canDivide = remainder <= newDivisor;
            if (remainder == 0 || !canDivide)
            {
                return isPositive ? quotient : -quotient;
            }
            remainder = dividend > 0 ? -remainder : remainder;
            var q = Divide(remainder, divisor);

            return isPositive ? q + quotient : q - quotient;
        }
    }
}

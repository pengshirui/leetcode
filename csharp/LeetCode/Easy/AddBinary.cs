using System;
using System.Text;

namespace LeetCode.Easy
{
    public partial class Solution
    {
        public string AddBinary(string a, string b)
        {
            if (a == Constants.Constants.ZeroStr)
            {
                return b;
            }

            if (b == Constants.Constants.ZeroStr)
            {
                return a;
            }

            var length = Math.Max(a.Length, b.Length);
            var list = new int[length + 1];

            for (var i = 0; i < length; i++)
            {
                var valOfA = i >= a.Length ? 0 : (a[a.Length - i - 1] - '0');
                var valOfB = i >= b.Length ? 0 : (b[b.Length - i - 1] - '0');
                var sum = valOfA + valOfB + list[i];
                var remainder = sum % 2;
                var carry = sum / 2;
                if (carry > 0)
                {
                    list[i + 1] += carry;
                }
                list[i] = remainder;
            }

            var sb = new StringBuilder();
            for (var i = list.Length - 1; i >= 0; i--)
            {
                if (!(sb.Length == 0 && list[i] == 0))
                {
                    sb.Append(list[i]);
                }
            }
            return sb.ToString();
        }
    }
}

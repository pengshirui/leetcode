namespace LeetCode.Bit.AddBinary
{
    using System.Collections.Generic;

    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            var sb = new List<char>();
            var i = a.Length - 1;
            var j = b.Length - 1;
            var carry = 0;
            while (i >= 0 || j >= 0)
            {
                int sum = carry;
                if (j >= 0) sum += b[j--] - '0';
                if (i >= 0) sum += a[i--] - '0';
                sb.Add((char)('0' + sum % 2));
                carry = sum / 2;
            }
            if (carry != 0) sb.Add((char)('0' + carry));
            sb.Reverse();
            return new string(sb.ToArray());
        }
    }
}

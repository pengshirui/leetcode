using System.Text;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == Constants.Constants.ZeroStr || num2 == Constants.Constants.ZeroStr)
            {
                return Constants.Constants.ZeroStr;
            }

            var list = new int[num1.Length + num2.Length];
            // i = index of num1
            for (var i = 0; i < num1.Length; i++)
            {
                // j index of num2
                for (var j = 0; j < num2.Length; j++)
                {
                    var sum = (num1[num1.Length - i - 1] - Constants.Constants.ZeroChar) * (num2[num2.Length - j - 1] - Constants.Constants.ZeroChar) + list[i + j];
                    var remainder = sum % 10;
                    var carry = sum / 10;
                    if (carry > 0)
                    {
                        list[i + 1 + j] += carry;
                    }
                    list[i + j] = remainder;
                }
            }

            // loop through list
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

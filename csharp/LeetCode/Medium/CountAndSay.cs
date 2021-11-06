namespace LeetCode.Medium.CountAndSay
{
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        public string CountAndSay(int n)
        {
            var res = "1";
            for (var i = 2; i <= n; i++)
            {
                var sb = new StringBuilder();
                var j = 0;
                while (j < res.Length)
                {
                    var item = res[j];
                    var count = 1;
                    while (j < res.Length - 1 && res[j] == res[j + 1])
                    {
                        j++;
                        count++;
                    }
                    sb.Append(count).Append(item);
                    j++;
                }
                res = sb.ToString();
            }
            return res;
        }
    }
}

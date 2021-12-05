namespace LeetCode.String.ProcessString
{
    using System.Collections.Generic;

    public class Solution
    {
        public string ProcessString(string input)
        {
            var cur = input;
            while (cur.Length > 3)
            {
                var num = 0;
                var part = "";
                for (var i = 0; i < cur.Length; i++)
                {
                    num += cur[i] - '0';
                    if ((i + 1) % 3 == 0)
                    {
                        part += num;
                        num = 0;
                    }
                }
                part += num;
                cur = part;
            }
            return cur;
        }
    }
}

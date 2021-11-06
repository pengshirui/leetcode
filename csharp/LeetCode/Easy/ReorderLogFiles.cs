namespace LeetCode.Easy
{
    using System.Collections.Generic;

    public partial class Solution
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            var letterLogs = new List<string>();
            var digitLogs = new List<int>();

            for (var i = 0; i < logs.Length; i++)
            {
                var firstSpace = logs[i].IndexOf(" ");
                if (char.IsLetter(logs[i][firstSpace + 1]))
                {
                    letterLogs.Add(logs[i]);
                }
                else
                {
                    digitLogs.Add(i);
                }
            }

            letterLogs.Sort((a, b) =>
            {
                string a_substr = a.Substring(a.IndexOf(' ') + 1);
                string b_substr = b.Substring(b.IndexOf(' ') + 1);
                var result = a_substr.CompareTo(b_substr);
                if (result == 0)
                {
                    result = a.Substring(0, a.IndexOf(' ')).CompareTo(b.Substring(0, b.IndexOf(' ')));
                }
                return result;
            });

            var ans = new string[logs.Length];
            var k = 0;
            foreach (var l in letterLogs)
            {
                ans[k] = l;
                k++;
            }
            foreach (var l in digitLogs)
            {
                ans[k] = logs[l];
                k++;
            }
            return ans;
        }
    }
}

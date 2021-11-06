namespace LeetCode.Easy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class Solution
    {
        public int NumUniqueEmails(string[] emails)
        {
            var set = new HashSet<string>();
            foreach (var email in emails)
            {
                var parts = email.Split('@');
                if (parts.Length != 2)
                {
                    continue;
                }
                var local = parts[0];
                var domain = parts[1];

                var sb = new StringBuilder();
                foreach (var c in local)
                {
                    if (c == '.')
                    {
                        continue;
                    }
                    else if (c == '+')
                    {
                        break;
                    }
                    sb.Append(c);
                }
                var key = sb.Append('@').Append(domain).ToString();
                if (!set.Contains(key))
                    set.Add(key);
            }
            return set.Count;
        }
    }
}

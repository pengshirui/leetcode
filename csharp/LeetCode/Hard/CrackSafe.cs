namespace LeetCode.Hard
{
    using System;
    using System.Collections.Generic;

    public partial class Solution
    {
        string ans = string.Empty;
        public string CrackSafe(int n, int k)
        {
            var prefix = string.Empty;
            for (var i = 0; i < n; i++)
            {
                prefix += '0';
            }
            var visited = new HashSet<string>();
            visited.Add(prefix);
            if (CrackSafeInternal(prefix, n, k, visited))
            {
                return ans;
            }
            return string.Empty;
        }

        bool CrackSafeInternal(string prefix, int n, int k, HashSet<string> visited)
        {
            if (visited.Count == Math.Pow(k, n))
            {
                ans = prefix;
                return true;
            }
            var prevN_1_digits = prefix.Substring(prefix.Length - n + 1, n - 1);

            for (var s = '0'; s < '0' + k; s++)
            {
                var newPass = prevN_1_digits + s;
                if (visited.Contains(newPass))
                    continue;
                visited.Add(newPass);
                if (CrackSafeInternal(prefix + s, n, k, visited))
                    return true;
                visited.Remove(newPass);
            }
            return false;
        }
    }
}

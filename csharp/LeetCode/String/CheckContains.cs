namespace LeetCode.String.CheckContains
{
    using System.Collections.Generic;

    public class Solution
    {
        public bool CheckContains(string[] a, string[] b)
        {
            var hs = new HashSet<string>();
            var c = "";
            foreach (var a0 in a)
            {
                c += a0;
                hs.Add(c);
            }

            foreach (var b0 in b)
            {
                if (!hs.Contains(b0)) return false;
            }
            return true;
        }
    }
}

namespace LeetCode.Easy.WordPattern
{
    using System.Collections.Generic;

    public class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            var words = s.Split(" ");
            if (words.Length != pattern.Length) return false;
            var kv = new Dictionary<object, int>();
            for (var i = 0; i < pattern.Length; i++)
            {
                var c = pattern[i];
                var w = words[i];
                var v1 = kv.GetValueOrDefault(c, -1);
                var v2 = kv.GetValueOrDefault(w, -1);
                if (v1 != v2) return false;
                kv.TryAdd(c, i);
                kv[c] = i;
                kv.TryAdd(w, i);
                kv[w] = i;
            }
            return true;
        }
    }
}

namespace LeetCode.Medium.LongestStrChain
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Solution
    {
        public int LongestStrChain(params string[] words)
        {
            if (words == null | words.Length == 0) return 0;
            Array.Sort(words, (x, y) => x.Length - y.Length);
            var result = 1;
            var kv = new Dictionary<string, int>();
            foreach (var word in words)
            {
                var max = 1;
                for (var i = 0; i < word.Length; i++)
                {
                    var sb = new StringBuilder(word);
                    sb.Remove(i, 1);
                    var newWord = sb.ToString();
                    var len = kv.GetValueOrDefault(newWord, 0);
                    max = Math.Max(max, len + 1);
                }
                kv[word] = max;
                result = Math.Max(result, max);
            }
            return result;
        }
    }

}

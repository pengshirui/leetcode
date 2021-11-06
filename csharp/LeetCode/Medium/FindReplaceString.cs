namespace LeetCode.Medium
{
    using System.Collections.Generic;
    using System.Text;

    public partial class Solution
    {
        public string FindReplaceString(string s, int[] indices, string[] sources, string[] targets)
        {
            var kv = new Dictionary<int, (int, string)>();
            for (var i = 0; i < indices.Length; i++)
            {
                var source = sources[i];
                var index = indices[i];

                if (index + source.Length <= s.Length)
                {
                    if (IsMatch(s, source, index))
                        kv[index] = (source.Length, targets[i]);
                }
            }

            var sb = new StringBuilder();
            var j = 0;
            while (j < s.Length)
            {
                if (kv.TryGetValue(j, out var value))
                {
                    var (length, str) = value;
                    sb.Append(str);
                    j += length;
                }
                else
                {
                    sb.Append(s[j++]);
                }
            }

            return sb.ToString();
        }

        private static bool IsMatch(string s, string source, int index)
        {
            for (var i = 0; i < source.Length; i++)
            {
                if (s[index++] != source[i]) return false;
            }

            return true;
        }
    }
}

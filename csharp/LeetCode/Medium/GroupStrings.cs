namespace LeetCode.Medium.GroupStrings
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Solution
    {
        public IList<IList<string>> GroupStrings(params string[] strings)
        {
            var kv = new Dictionary<string, IList<string>>();
            for (var i = 0; i < strings.Length; i++)
            {
                var str = strings[i];
                var sb = new StringBuilder();
                for (var j = 1; j < str.Length; j++)
                {
                    var diff = str[j] - str[j - 1];
                    if (diff < 0)
                    {
                        diff = (diff + 26) % 26;
                    }
                    sb.Append(diff).Append(",");
                }
                var key = sb.ToString();
                kv.TryAdd(key, new List<string>());
                kv[key].Add(str);
            }
            return kv.Values.ToList();
        }
    }
}

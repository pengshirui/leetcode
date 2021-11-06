namespace LeetCode.Medium.FindDuplicate
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Solution
    {
        public IList<IList<string>> FindDuplicate(string[] paths)
        {
            var kv = new Dictionary<string, IList<string>>();
            foreach (var path in paths)
            {
                var parts = path.Split(" ");
                var folder = parts[0];
                for (var i = 1; i < parts.Length; i++)
                {
                    var (name, content) = GetFileNameAndContent(parts[i]);
                    kv.TryAdd(content, new List<string>());
                    var wholePath = $"{folder}/{name}";
                    kv[content].Add(wholePath);
                }
            }

            return kv.Values.Where(v => v.Count > 1).ToList();
        }

        (string, string) GetFileNameAndContent(string file)
        {
            var sb = new StringBuilder();
            var name = string.Empty;
            var content = string.Empty;
            foreach (var c in file)
            {
                if (c == '(')
                {
                    name = sb.ToString();
                    sb = new StringBuilder();
                }
                else if (c == ')')
                {
                    content = sb.ToString();
                }
                else
                {
                    sb.Append(c);
                }
            }
            return (name, content);
        }
    }
}

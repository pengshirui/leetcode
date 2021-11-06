namespace LeetCode.Medium.SimplifyPath
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public string SimplifyPath(string path)
        {
            var paths = path.Split("/");
            var stack = new List<string>();
            for (var i = 0; i < paths.Length; i++)
            {
                if (paths[i] == "." || string.IsNullOrWhiteSpace(paths[i]))
                {
                    continue;
                }
                else if (paths[i] == "..")
                {
                    if (stack.Any()) stack.RemoveAt(stack.Count - 1);
                }
                else
                {
                    stack.Add(paths[i]);
                }
            }
            return "/" + string.Join('/', stack);
        }
    }
}

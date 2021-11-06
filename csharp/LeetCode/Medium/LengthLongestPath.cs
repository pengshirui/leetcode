namespace LeetCode.Medium.LengthLongestPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public int LengthLongestPath(string input)
        {
            var parts = input.Split("\n");
            var dirs = new Stack<Node>();
            var res = 0;
            for (var i = 0; i < parts.Length; i++)
            {
                var node = GetNode(parts[i]);
                // Remove any directories above this one.
                while (dirs.Any() && dirs.Peek().Level >= node.Level)
                {
                    dirs.Pop();
                }
                if (dirs.Any())
                {
                    node.Length += dirs.Peek().Length;
                }
                if (node.IsDir)
                {
                    dirs.Push(node);
                    continue;
                }
                res = Math.Max(res, node.Length + node.Level);
            }
            return res;
        }

        bool IsDir(string path)
        {
            for (var i = path.Length - 1; i >= 0; i--)
            {
                if (path[i] == '.') return false;
            }
            return true;
        }

        Node GetNode(string path)
        {
            var last = path.LastIndexOf("\t");

            var s = path.Replace("\t", "");
            var n = path.Substring(last + 1);
            var node = new Node
            {
                Name = n,
                Level = path.Length - s.Length,
                IsDir = IsDir(n),
                Length = n.Length,
            };
            return node;
        }

        class Node
        {
            public string Name;
            public int Level;
            public int Length;
            public bool IsDir;
        }
    }
}

namespace LeetCode.Hard.AlienOrder
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Solution
    {
        public string AlienOrder(params string[] words)
        {
            var nodes = new Node[26];
            foreach (var word in words)
            {
                foreach (var c in word)
                {
                    if (nodes[c - 'a'] == null) nodes[c - 'a'] = new Node(c);
                }
            }
            for (var i = 1; i < words.Length; i++)
            {
                // Check that word2 is not a prefix of word1.
                if (words[i - 1].Length > words[i].Length && words[i - 1].StartsWith(words[i]))
                {
                    return string.Empty;
                }
                for (var j = 0; j < words[i].Length && j < words[i - 1].Length; j++)
                {
                    if (words[i - 1][j] != words[i][j])
                    {
                        var a = words[i - 1][j];
                        var b = words[i][j];

                        var first = nodes[a - 'a'];
                        var second = nodes[b - 'a'];
                        first.Next.Add(second);
                        second.Indegree++;
                        break;
                    }
                }

            }

            // Add 0 indegree node
            var q = new Queue<Node>();
            var totalNodes = 0;
            foreach (var n in nodes)
            {

                if (n != null)
                {
                    totalNodes++;
                    if (n.Indegree == 0) q.Enqueue(n);
                }
            }

            var result = new StringBuilder();
            while (q.Any())
            {
                var node = q.Dequeue();
                result.Append(node.Val);
                foreach (var nextNode in node.Next)
                {
                    nextNode.Indegree--;
                    if (nextNode.Indegree == 0)
                    {
                        q.Enqueue(nextNode);
                    }
                }
            }
            return result.Length == totalNodes ? result.ToString() : string.Empty;
        }
    }

    class Node
    {
        public char Val;
        public IList<Node> Next = new List<Node>();
        public int Indegree = 0;
        public Node(char c)
        {
            Val = c;
        }
    }
}

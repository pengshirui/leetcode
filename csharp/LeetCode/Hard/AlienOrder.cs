namespace LeetCode.Hard.AlienOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Solution
    {
        StringBuilder Res = new StringBuilder();
        List<int>[] Next = new List<int>[26];
        int[] Indegree = new int[26];
        Queue<int> q = new Queue<int>();
        public string AlienOrder(params string[] words)
        {
            Array.Fill(Indegree, -1);
            foreach (var w in words)
            {
                foreach (var c in w)
                {
                    if (Next[c - 'a'] == null) Next[c - 'a'] = new List<int>();
                    Indegree[c - 'a'] = 0;
                }
            }

            for (var i = 1; i < words.Length; i++)
            {
                var w0 = words[i - 1];
                var w1 = words[i];
                var len = Math.Min(w0.Length, w1.Length);
                var j = 0;
                while (j < len && w0[j] == w1[j])
                {
                    j++;
                }
                if (j == len && w0.Length > w1.Length) return string.Empty;
                if (j >= len) continue;
                var u = w0[j];
                var v = w1[j];
                Next[u - 'a'].Add(v - 'a');
                Indegree[v - 'a']++;
            }

            return TopSort();
        }

        string TopSort()
        {
            var cnt1 = 0;
            for (var i = 0; i < 26; i++)
            {
                if (Indegree[i] == 0)
                {
                    q.Enqueue(i);
                }
                if (Indegree[i] != -1)
                {
                    cnt1++;
                }
            }
            var cnt2 = 0;
            while (q.Any())
            {
                var c = q.Dequeue();
                Res.Append((char)(c + 'a'));
                cnt2++;
                foreach (var n in Next[c])
                {
                    Indegree[n]--;
                    if (Indegree[n] == 0)
                    {
                        q.Enqueue(n);
                    }
                }
            }
            return cnt1 == cnt2 ? Res.ToString() : string.Empty;
        }
    }
}

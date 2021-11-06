namespace LeetCode.DataStructures
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class AutocompleteSystem
    {
        private readonly RankedTrieNode Root = new RankedTrieNode();
        private readonly StringBuilder Sb = new StringBuilder();
        private RankedTrieNode Current;

        public AutocompleteSystem(string[] sentences, int[] times)
        {
            for (var i = 0; i < sentences.Length; i++)
            {
                Add(sentences[i], times[i]);
            }
            Current = Root;
        }

        public IList<string> Input(char c)
        {
            var top3 = new List<string>();
            if (c == '#')
            {
                Add(Sb.ToString(), 1);
                Sb.Clear();
                Current = Root;
                return top3;
            }
            Sb.Append(c);
            var index = c == ' ' ? 26 : c - 'a';
            if (Current.Next[index] == null)
            {
                Current.Next[index] = new RankedTrieNode();
                Current = Current.Next[index];
                return top3;
            }
            Current = Current.Next[index];
            var list = Current.Ranks.ToList();
            list.Sort((x, y) =>
            {
                var r = y.Value.CompareTo(x.Value);
                if (r == 0)
                {
                    return x.Key.CompareTo(y.Key);
                }
                return r;
            });
            top3 = list.Take(3).Select(l => l.Key).ToList();
            return top3;
        }

        private void Add(string sentence, int time)
        {
            var cur = Root;
            for (var j = 0; j < sentence.Length; j++)
            {
                var c = sentence[j];
                var index = c == ' ' ? 26 : c - 'a';
                if (cur.Next[index] == null)
                {
                    cur.Next[index] = new RankedTrieNode();
                }

                cur = cur.Next[index];
                cur.Ranks.TryAdd(sentence, 0);
                cur.Ranks[sentence] += time;
            }
        }
    }

    class RankedTrieNode
    {
        public Dictionary<string, int> Ranks = new Dictionary<string, int>();
        public RankedTrieNode[] Next = new RankedTrieNode[27];
    }

}

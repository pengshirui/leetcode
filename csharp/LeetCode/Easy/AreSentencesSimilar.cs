namespace LeetCode.Easy
{
    using System.Collections.Generic;

    public partial class Solution
    {

        private readonly Dictionary<string, string> Dictionary = new Dictionary<string, string>();
        public bool AreSentencesSimilar(string[] sentence1, string[] sentence2, IList<IList<string>> similarPairs)
        {
            if (sentence1?.Length != sentence2?.Length)
            {
                return false;
            }

            // init dictionary
            foreach (var pair in similarPairs)
            {
                if (!Dictionary.ContainsKey(pair[0]))
                {
                    Dictionary[pair[0]] = pair[0];
                }
                if (!Dictionary.ContainsKey(pair[1]))
                {
                    Dictionary[pair[1]] = pair[1];
                }
            }

            foreach (var pair in similarPairs)
            {
                Union(pair[0], pair[1]);
            }

            for (var i = 0; i < sentence1.Length; i++)
            {
                var word1 = sentence1[i];
                var word2 = sentence2[i];
                if (word1 != word2 && FindString(word1) != FindString(word2))
                {
                    return false;
                }
            }

            return true;
        }


        string FindString(string key)
        {
            if (Dictionary.TryGetValue(key, out var value))
            {
                if (value != key)
                {
                    Dictionary[key] = FindString(Dictionary[key]);
                }
                return value;
            }
            else
            {
                return key;
            }
        }


        private void Union(string v1, string v2)
        {
            Dictionary[v1] = FindString(v2);
        }
    }
}

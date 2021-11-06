namespace LeetCode.Easy
{
    public partial class Solution
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            if (words.Length <= 1)
                return true;
            var dictionary = new int[26];
            var rank = 0;
            foreach (var c in order)
            {
                dictionary[c - 'a'] = rank++;
            }

            for (var i = 1; i < words.Length; i++)
            {
                var cur = words[i];
                var prev = words[i - 1];
                if (!IsSorted(prev, cur, dictionary))
                    return false;
            }
            return true;
        }

        bool IsSorted(string s1, string s2, int[] order)
        {
            for (var j = 0; j < s1.Length && j < s2.Length; j++)
            {
                if (s1[j] == s2[j])
                {
                    continue;
                }
                else if (order[s1[j] - 'a'] < order[s2[j] - 'a'])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return s2.Length >= s1.Length;
        }
    }
}

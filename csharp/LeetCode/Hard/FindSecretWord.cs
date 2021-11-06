namespace LeetCode.Hard.FindSecretWord
{
    using System.Collections.Generic;
    using System.Linq;
    using LeetCode.DataStructures;

    public class Solution
    {
        public void FindSecretWord(string[] wordlist, Master master)
        {
            int count = 10;
            while (count-- > 0)
            {
                //char, count
                var dict = new int[26];
                foreach (string word in wordlist)
                {
                    foreach (char c in word)
                    {
                        dict[c - 'a']++;
                    }
                }

                string guess = string.Empty;
                int maxScore = 0;
                foreach (string word in wordlist)
                {
                    int score = 0;
                    foreach (char c in word)
                        score += dict[c - 'a'];

                    if (score > maxScore)
                    {
                        guess = word;
                        maxScore = score;
                    }
                }
                int res = master.Guess(guess);

                if (res == 6)
                    return;

                HashSet<string> candidates = new HashSet<string>();
                foreach (string word in wordlist)
                {
                    if (word != guess && MatchCount(guess, word) == res)
                        candidates.Add(word);
                }

                wordlist = candidates.ToArray();
            }
        }

        private int MatchCount(string w1, string w2)
        {
            int ans = 0;
            for (int i = 0; i < w1.Length; i++)
            {
                if (w1[i] == w2[i]) ans++;
            }
            return ans;
        }
    }
}

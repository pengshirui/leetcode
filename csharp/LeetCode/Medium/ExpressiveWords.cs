namespace LeetCode.Medium
{
    public partial class Solution
    {
        public int ExpressiveWords(string s, string[] words)
        {
            var ans = 0;
            foreach (var word in words)
            {
                if (IsStretchy(s, word))
                {
                    ans++;
                }
            }
            return ans;
        }

        private bool IsStretchy(string s, string word)
        {
            var i = 0;
            var j = 0;
            while (i < s.Length && j < word.Length)
            {
                if (s[i] != word[j])
                {
                    break;
                }
                var dup1 = 1;
                while (i + 1 < s.Length && s[i] == s[i + 1])
                {
                    i++;
                    dup1++;
                }
                var dup2 = 1;
                while (j + 1 < word.Length && word[j] == word[j + 1])
                {
                    j++;
                    dup2++;
                }
                if (dup1 == dup2 || dup1 - dup2 >= 2)
                {
                    i++;
                    j++;
                }
                else
                {
                    break;
                }

            }
            return i == s.Length && j == word.Length;
        }
    }
}

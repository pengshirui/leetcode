namespace LeetCode.Easy.ValidWordAbbreviation
{
    public class Solution
    {
        public bool ValidWordAbbreviation(string word, string abbr)
        {
            var p1 = 0;
            var p2 = 0;
            var count = 0;
            while (p1 < word.Length && p2 < abbr.Length)
            {
                if (abbr[p2] == '0') return false;
                while (p2 < abbr.Length && char.IsDigit(abbr[p2]))
                {
                    count = count * 10 + abbr[p2++] - '0';
                }
                p1 += count;
                count = 0;

                if (p1 < word.Length && p2 < abbr.Length && word[p1++] != abbr[p2++])
                {
                    return false;
                }
            }
            return count == 0 && p1 == word.Length && p2 == abbr.Length;
        }
    }
}

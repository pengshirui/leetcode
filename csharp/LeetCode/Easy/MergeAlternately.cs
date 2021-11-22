namespace LeetCode.Easy.MergeAlternately
{
    using System.Text;

    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var sb = new StringBuilder();

            var i = 0;
            var j = 0;
            while (i < word1.Length && j < word2.Length)
            {
                sb.Append(word1[i++]);
                sb.Append(word2[j++]);
            }
            if (i < word1.Length)
            {
                sb.Append(word1, i, word1.Length - i);
            }
            if (j < word2.Length)
            {
                sb.Append(word2, j, word2.Length - j);
            }
            return sb.ToString();
        }
    }
}

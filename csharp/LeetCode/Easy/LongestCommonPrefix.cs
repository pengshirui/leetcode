namespace LeetCode.Easy.LongestCommonPrefix
{
    using System.Text;

    public class Solution
    {
        public string LongestCommonPrefix(params string[] strs)
        {
            var word = strs[0];
            var result = new StringBuilder();
            for (var i = 0; i < word.Length; i++)
            {
                for (var j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || word[i] != strs[j][i])
                    {
                        return result.ToString();
                    }
                }
                result.Append(word[i]);
            }
            return result.ToString();
        }
    }
}

namespace LeetCode.Easy
{
    public partial class Solution
    {
        public int FirstUniqChar(string s)
        {
            var letters = new int[26];

            foreach (var c in s)
            {
                letters[c - 'a']++;
            }

            for (var i = 0; i < s.Length; i++)
            {
                if (letters[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

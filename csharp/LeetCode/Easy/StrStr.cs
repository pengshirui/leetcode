namespace LeetCode.Easy
{
    public partial class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack == needle)
            {
                return 0;
            }

            for (var i = 0; i < haystack.Length; i++)
            {
                var j = 0;
                while (i + j < haystack.Length && j < needle.Length && haystack[i + j] == needle[j])
                {
                    j++;
                }
                if (j == needle.Length && i + j <= haystack.Length)
                {
                    return i;
                }
            }
            haystack.IndexOfAny(needle.ToCharArray());

            return -1;
        }
    }
}

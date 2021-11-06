namespace LeetCode.Medium.WordsTyping
{
    public class Solution
    {
        public int WordsTyping(string[] sentence, int rows, int cols)
        {
            var s = string.Join(" ", sentence) + " ";
            var ptr = 0;
            var l = s.Length;
            for (var i = 0; i < rows; i++)
            {
                ptr += cols;
                if (s[ptr % l] == ' ')
                {
                    ptr++;
                }
                else
                {
                    while (ptr > 0 && s[(ptr - 1) % l] != ' ')
                    {
                        ptr--;
                    }
                }
            }
            return ptr / l;
        }
    }
}

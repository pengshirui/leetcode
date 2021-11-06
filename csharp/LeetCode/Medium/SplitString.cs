namespace LeetCode.Medium.SplitString
{
    public class Solution
    {
        public bool SplitString(string s)
        {
            long num = 0;
            for (var i = 0; i < s.Length - 1; i++)
            {
                num = 10 * num + (s[i] - '0');
                if (num.ToString().Length > s.Length - i) return false;
                if (CanSplit(num, s, i + 1))
                {
                    return true;
                }
            }
            return false;
        }

        bool CanSplit(long num, string s, int start)
        {
            long current = 0;
            for (var i = start; i < s.Length; i++)
            {
                current = 10 * current + (s[i] - '0');
                if (current == num - 1)
                {
                    if (CanSplit(current, s, i + 1))
                    {
                        return true;
                    }
                }
                else if (current > num - 1)
                {
                    return false;
                }
            }
            return current == num - 1;
        }
    }
}

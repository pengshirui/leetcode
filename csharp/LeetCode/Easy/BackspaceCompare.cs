namespace LeetCode.Easy
{
    public partial class Solution
    {
        public bool BackspaceCompare(string s, string t)
        {
            var i = s.Length - 1;
            var j = t.Length - 1;
            var skip = 0;
            while (i >= 0 || j >= 0)
            {
                while (i >= 0)
                {
                    if (s[i] == '#')
                    {
                        skip++;
                        i--;
                    }
                    else if (skip > 0)
                    {
                        skip--;
                        i--;
                    }
                    else
                    {
                        break;
                    }
                }

                skip = 0;
                while (j >= 0)
                {
                    if (t[j] == '#')
                    {
                        skip++;
                        j--;
                    }
                    else if (skip > 0)
                    {
                        skip--;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
                if (i >= 0 && j >= 0 && s[i] != t[j])
                {
                    return false;
                }

                i--;
                j--;
            }
            return i == j;
        }
    }
}

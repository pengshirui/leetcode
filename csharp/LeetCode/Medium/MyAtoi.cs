namespace LeetCode.Medium
{
    public partial class Solution
    {
        public int MyAtoi(string s)
        {
            var leadingCheckDone = false;
            var isPositive = true;
            long result = 0;
            foreach (var c in s)
            {
                if (leadingCheckDone)
                {
                    if (char.IsDigit(c))
                    {
                        var newVal = result * 10 + int.Parse(c.ToString());
                        if (newVal > int.MaxValue)
                        {
                            // overflow
                            return isPositive ? int.MaxValue : int.MinValue;
                        }
                        else
                        {
                            result = newVal;
                        }
                    }
                    else
                    {
                        return (int)(isPositive ? result : result * -1);
                    }
                }
                else
                {
                    if (c == ' ')
                    {
                        // space is ok.
                        continue;
                    }
                    else if (char.IsDigit(c))
                    {
                        // first non-zero digit hits
                        result = int.Parse(c.ToString());
                        leadingCheckDone = true;
                    }
                    else if (c == '+' || c == '-')
                    {
                        // sign hits
                        isPositive = c == '+';
                        leadingCheckDone = true;
                    }
                    else
                    {
                        return (int)result;
                    }
                }
            }

            return (int)(isPositive ? result : result * -1);
        }
    }
}

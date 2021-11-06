namespace LeetCode.Hard
{
    using System.Collections.Generic;
    using System.Text;

    public partial class Solution
    {
        public IList<string> AddOperators(string num, int target)
        {
            var result = new List<string>();
            DFS(num.ToCharArray(), 0, new StringBuilder(), 0, 0, target, result);
            return result;
        }

        void DFS(char[] num, int start, StringBuilder prevSb, long prev, long prevTotal, int target, IList<string> result)
        {
            if (start == num.Length && prevTotal == target)
            {
                result.Add(prevSb.ToString());
            }
            else if (start < num.Length)
            {
                var len = prevSb.Length;
                long current = 0;
                var str = new StringBuilder();
                for (var i = start; i < num.Length; i++)
                {
                    str.Append(num[i]);

                    if (str[0] == '0' && str.Length > 1)
                    {
                        break;
                    }
                    current = current * 10 + (num[i] - '0');
                    if (start == 0)
                    {
                        prevSb.Append(str);
                        DFS(num, i + 1, prevSb, current, current, target, result);
                        prevSb.Clear();
                        continue;
                    }

                    // +
                    var newPrev = current;
                    var newTotal = prevTotal + newPrev;
                    prevSb.Append('+').Append(current);
                    var newLen = prevSb.Length - len;
                    DFS(num, i + 1, prevSb, newPrev, newTotal, target, result);
                    prevSb.Remove(len, newLen);
                    // -
                    newPrev = -current;
                    newTotal = prevTotal + newPrev;
                    prevSb.Append('-').Append(current);
                    newLen = prevSb.Length - len;
                    DFS(num, i + 1, prevSb, newPrev, newTotal, target, result);
                    prevSb.Remove(len, newLen);
                    // *
                    newPrev = current * prev;
                    newTotal = prevTotal - prev + newPrev;
                    prevSb.Append('*').Append(current);
                    DFS(num, i + 1, prevSb, newPrev, newTotal, target, result);
                    prevSb.Remove(len, newLen);
                }
            }
        }
    }
}

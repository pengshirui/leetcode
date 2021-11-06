namespace LeetCode.Hard.RemoveInvalidParentheses
{
    using System.Collections.Generic;

    public class Solution
    {
        public IList<string> RemoveInvalidParentheses(string s)
        {
            var open = 0;
            var close = 0;
            foreach (var c in s)
            {
                if (c == '(')
                {
                    open++;
                }
                else if (c == ')')
                {
                    if (open > 0)
                    {
                        open--;
                    }
                    else
                    {
                        close++;
                    }
                }
            }
            var results = new HashSet<string>();
            DFS(results, string.Empty, s, 0, open, close, 0);
            return new List<string>(results);
        }

        void DFS(HashSet<string> results, string result, string s, int index, int open, int close, int count)
        {
            if (index == s.Length)
            {
                if (open == 0 && close == 0 && count == 0)
                {
                    results.Add(result);
                }
                return;
            }
            var cur = s[index];
            if (cur == '(')
            {
                if (open > 0)
                {
                    // too many open, skip
                    DFS(results, result, s, index + 1, open - 1, close, count);
                }
                // use
                DFS(results, result + cur, s, index + 1, open, close, count + 1);

            }
            else if (cur == ')')
            {
                if (close > 0)
                {
                    // too many close, skip
                    DFS(results, result, s, index + 1, open, close - 1, count);
                }
                if (count > 0)
                {
                    // use
                    DFS(results, result + cur, s, index + 1, open, close, count - 1);
                }

            }
            else
            {
                DFS(results, result + cur, s, index + 1, open, close, count);
            }
        }
    }
}

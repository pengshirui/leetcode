namespace LeetCode.Medium
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solution
    {
        Dictionary<string, IList<int>> Memo;
        public IList<int> DiffWaysToCompute(string expression)
        {
            Memo = new Dictionary<string, IList<int>>();
            return DiffWaysToComputeIntenral(expression);
        }

        IList<int> DiffWaysToComputeIntenral(string expression)
        {
            if (Memo.TryGetValue(expression, out var val))
            {
                return val;
            }
            var ans = new List<int>();
            for (var i = 1; i < expression.Length; i++)
            {
                if (char.IsDigit(expression[i]))
                {
                    continue;
                }
                var leftStr = expression.Substring(0, i);
                var leftAns = DiffWaysToComputeIntenral(leftStr);
                var rightStr = expression.Substring(i + 1);
                var rightAns = DiffWaysToComputeIntenral(rightStr);
                foreach (var l in leftAns)
                {
                    foreach (var r in rightAns)
                    {
                        var a = 0;
                        if (expression[i] == '+')
                        {
                            a = l + r;
                        }
                        else if (expression[i] == '-')
                        {
                            a = l - r;
                        }
                        else if (expression[i] == '*')
                        {
                            a = l * r;
                        }
                        ans.Add(a);
                    }
                }
            }
            if (!ans.Any())
            {
                ans.Add(int.Parse(expression));
            }
            Memo[expression] = ans;
            return ans;
        }
    }
}

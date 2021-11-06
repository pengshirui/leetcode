namespace LeetCode.DFS.LetterCombinations
{
    using System.Collections.Generic;

    public class Solution
    {
        IList<string> Result = new List<string>();
        string[] Map = new string[]
        {
        "", // 0
        "", // 1
        "abc", // 2
        "def", // 3
        "ghi",
        "jkl",
        "mno",
        "pqrs",
        "tuv",
        "wxyz",
        };
        string D;
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits)) return Result;
            D = digits;
            DFS(string.Empty, 0);
            return Result;
        }

        void DFS(string res, int start)
        {
            if (!string.IsNullOrEmpty(res) && start == D.Length)
            {
                Result.Add(res);
                return;
            }
            var d = D[start];
            foreach (var c in Map[d - '0'])
            {
                DFS(res + c, start + 1);
            }
        }
    }
}

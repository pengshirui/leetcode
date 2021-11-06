namespace LeetCode.Hard.FullJustify
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var result = new List<string>();
            var list = new List<string>();
            var k = maxWidth;
            var i = 0;
            while (i < words.Length)
            {
                var word = words[i];
                var needSpace = list.Count > 0 ? 1 : 0;
                var needLength = word.Length + needSpace;
                if (k > 0 && needLength <= k)
                {
                    list.Add(word);
                    k -= needLength;
                    i++;
                }
                else
                {
                    AddToResult(result, list, k);
                    k = maxWidth;
                    list = new List<string>();
                }
            }
            if (list.Any())
            {
                var str = string.Join(" ", list);
                k = maxWidth - str.Length;
                while (k-- > 0)
                {
                    str += " ";
                }
                result.Add(str);
            }
            return result;
        }

        void AddToResult(IList<string> result, IList<string> list, int k)
        {
            var i = 0;
            while (k > 0 && list.Count > 1)
            {
                i %= (list.Count - 1);
                list[i] += " ";
                i++;
                k--;
            }
            while (k > 0 && list.Count == 1)
            {
                list[0] += " ";
                k--;
            }
            result.Add(string.Join(" ", list));
        }
    }
}

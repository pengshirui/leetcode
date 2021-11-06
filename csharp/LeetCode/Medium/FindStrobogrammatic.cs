namespace LeetCode.Medium
{
    using System.Collections.Generic;

    public partial class Solution
    {
        private readonly List<string> Even = new List<string> { "0", "1", "8" };
        private readonly List<string> Odd = new List<string> { "11", "69", "88", "96", "00" };
        private readonly Dictionary<int, IList<string>> Results = new Dictionary<int, IList<string>>()
        {
            { 1, new List<string> { "0", "1", "8" } },
            { 2, new List<string> { "11", "69", "88", "96" } }
        };

        public IList<string> FindStrobogrammatic(int n)
        {
            if (n < 3)
            {
                return Results[n];
            }

            var k = 3;
            while (k <= n)
            {
                var index = k % 2 == 0 ? k - 2 : k - 1;
                var list = new List<string>();
                foreach (var m in Results[index])
                {
                    var mid = k % 2 == 0 ? (k - 2) / 2 : (k - 1) / 2;
                    var set = k % 2 == 0 ? Odd : Even;
                    foreach (var e in set)
                    {
                        var newStr = m.Insert(mid, e);
                        list.Add(newStr);
                    }
                }
                Results[k] = list;
                k++;
            }
            return Results[n];
        }
    }
}

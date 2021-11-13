namespace Playground
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    class Program
    {
        static void Main(String[] args)
        {
            var dict = new Dictionary<int, int>();
            foreach (var (k, v) in dict.OrderByDescending(d => d.Value))
            {
            }
        }
    }

    class Solution
    {
        int N;
        public int GetResult(int n)
        {
            return n;
        }
    }

}

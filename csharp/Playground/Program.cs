namespace Playground
{
    using System;
    using System.Diagnostics;
    using System.Text;

    class Program
    {
        static void Main(String[] args)
        {
            var s = new Solution();
            var r = s.GetResult(5);
            Console.WriteLine(r);
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

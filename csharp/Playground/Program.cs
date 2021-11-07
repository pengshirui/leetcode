namespace Playground
{
    using System;
    using System.Diagnostics;
    using System.Text;

    class Program
    {
        static void Main(String[] args)
        {
            var c = (long)1e8;
            var t = new Stopwatch();
            t.Start();
            var a = new int[c];
            for (var i = 0; i < c; i++)
            {
                a[i] = 1;
            }
            //Array.Fill(a, 1);
            t.Stop();
            Console.WriteLine(t.ElapsedMilliseconds);
        }

    }
}

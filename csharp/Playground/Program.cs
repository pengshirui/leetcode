namespace Playground
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Net.Http;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    class Program
    {
        

        class Solution
        {
            const int N = 9;
            const int M = 1 << N;
            int[] row = new int[N];
            int[] col = new int[N];
            int[,] cell = new int[3, 3];
            char[][] b;
            // bit representation number: open slots 
            int[] slots = new int[M];
            public int[] Get()
            {
                for (var i = 0; i < M; i++)
                    for (var j = 0; j < N; j++)
                        slots[i] += i >> j & 1;
                return slots;
            }
        }


        static void Main(String[] args)
        {
            
        }
    }


}

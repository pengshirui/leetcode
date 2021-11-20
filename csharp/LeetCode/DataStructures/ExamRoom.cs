namespace LeetCode.DataStructures
{
    using System;
    using System.Collections.Generic;

    public class ExamRoom
    {
        int N;
        List<int> seats = new List<int>();

        public ExamRoom(int n)
        {
            N = n;
        }

        public int Seat()
        {
            if (seats.Count == N) return -1;
            if (seats.Count == 0)
            {
                seats.Add(0);
                return 0;
            }
            int d = Math.Max(seats[0], N - 1 - seats[seats.Count - 1]);
            for (var i = 1; i < seats.Count; i++)
            {
                d = Math.Max(d, seats[i] - seats[i - 1] >> 1);
            }

            if (seats[0] == d)
            {
                seats.Insert(0, 0);
                return 0;
            }

            for (int i = 1; i < seats.Count; i++)
            {
                if (seats[i] - seats[i - 1] >> 1== d)
                {
                    seats.Insert(i, seats[i] + seats[i - 1] >> 1);
                    return seats[i];
                }
            }

            seats.Add(N - 1);
            return N - 1;

        }

        public void Leave(int p)
        {
            var l = 0;
            var r = seats.Count;
            while (l < r)
            {
                var m = l + r >> 1;
                if (seats[m] == p)
                {
                    seats.RemoveAt(m);
                    return;
                }
                else if (seats[m] < p)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }
        }
    }

}

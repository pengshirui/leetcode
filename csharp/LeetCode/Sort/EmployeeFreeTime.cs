namespace LeetCode.Sort.EmployeeFreeTime
{
    using System;
    using System.Collections.Generic;


    public class Interval
    {
        public int start;
        public int end;

        public Interval() { }
        public Interval(int _start, int _end)
        {
            start = _start;
            end = _end;
        }
    }

    public class Solution
    {
        public IList<Interval> EmployeeFreeTime(IList<IList<Interval>> schedule)
        {
            var list = new List<Interval>();
            foreach (var s in schedule)
            {
                foreach (var i in s)
                {
                    list.Add(i);
                }
            }

            list.Sort((x, y) => x.start.CompareTo(y.start));

            var start = list[0].start;
            var end = list[0].end;
            var result = new List<Interval>();
            foreach (var i in list)
            {
                var a = i.start;
                var b = i.end;
                if (a <= end)
                {
                    end = Math.Max(end, b);
                }
                else
                {
                    var itv = new Interval(end, a);
                    result.Add(itv);
                    start = a;
                    end = b;
                }
            }

            return result;
        }
    }
}
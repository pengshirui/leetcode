namespace Playground
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(String[] args)
        {
            var str = new string[][]
            {
                new string[] {"APPEND","You'll never find a rainbow if you're looking down"},
                new string[] { "SELECT","6","50" },
                new string[] { "BACKSPACE" },
                new string[] { "SELECT","0","6" },
                new string[] { "COPY" },
                new string[] { "PASTE" },
                new string[] { "PASTE" },
                new string[] { "PASTE" },
            };
            var c = textEditor1_2(str);
        }
        static string APP = "APPEND";
        static string MV = "MOVE";
        static string BS = "BACKSPACE";
        static string SL = "SELECT";
        static string CP = "COPY";
        static string PS = "PASTE";

        static int l = 0;
        static int r = 0;
        static string copy;
        static StringBuilder sb = new StringBuilder();

        static string[] textEditor1_2(string[][] queries)
        {
            var res = new string[queries.Length];
            if (queries == null || queries.Length == 0) return res;

            for (var i = 0; i < queries.Length; i++)
            {
                var q = queries[i];
                if (q.Length > 4 || q.Length == 0) continue;
                var p0 = q[0]; // cmd

                if (p0 == APP)
                {
                    if (r > 0)
                    {
                        RemoveSelect();
                    }

                    sb.Insert(l, q[1]);
                    l += q[1].Length;
                }
                else if (p0 == MV)
                {

                    if (int.TryParse(q[1], out var n))
                    {
                        l = AdjustPtr(sb.Length, n);
                    }
                    // invalid p1;
                    else
                    {
                        continue;
                    }

                }
                else if (p0 == BS)
                {
                    if (sb.Length > 0)
                    {
                        if (r > 0) RemoveSelect();
                        else
                        {
                            sb.Remove(l - 1, 1);
                            l--;
                        }

                        l = AdjustPtr(sb.Length, l);
                    }
                }
                else if (p0 == SL)
                {
                    l = int.Parse(q[1]);
                    var end = int.Parse(q[2]);
                    r = Math.Min(sb.Length, end) - l;
                }
                else if (p0 == CP)
                {
                    copy = sb.ToString().Substring(l, r);
                }
                else if (p0 == PS)
                {
                    if (r > 0) RemoveSelect();
                    sb.Insert(l, copy);
                }
                res[i] = sb.ToString();
            }

            return res;
        }

        static void RemoveSelect()
        {
            sb.Remove(l, r);
            r = 0;
        }
        static int AdjustPtr(int len, int ptr)
        {
            if (ptr < 0)
            {
                ptr = 0;
            }
            else if (ptr > len)
            {
                ptr = len;
            }
            return ptr;
        }



    }
}

namespace LeetCode.Medium.MinimumJumps
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public int MinimumJumps(int[] forbidden, int a, int b, int x)
        {
            // (m, n, canBack)
            var q = new Queue<(int, int, bool)>();

            var fb = new HashSet<int>(forbidden);
            q.Enqueue((0, 0, true));
            while (q.Any())
            {
                var (m, n, canBack) = q.Dequeue();
                var pos = m * a - n * b;
                if (pos == x) return m + n;
                if (canBack)
                {
                    // go back
                    var p1 = m * a - (n + 1) * b;
                    if (p1 > 0 && !fb.Contains(p1))
                    {
                        fb.Add(p1);
                        q.Enqueue((m, n + 1, false));
                    }
                }
                // go forward
                var p2 = (m + 1) * a - n * b;
                if (p2 < 6000 && !fb.Contains(p2))
                {
                    fb.Add(p2);
                    q.Enqueue((m + 1, n, true));
                }
            }
            return -1;
        }
    }
}

namespace LeetCode.Hard.GetCollisionTimes
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public double[] GetCollisionTimes(int[][] cars)
        {
            var n = cars.Length;
            var res = new double[n];
            // track the index of prev collision
            var stack = new Stack<int>();

            for (int i = n - 1; i >= 0; i--)
            {
                res[i] = -1.0;
                int p = cars[i][0];
                var s = cars[i][1];
                while (stack.Any())
                {
                    var j = stack.Peek();
                    var p2 = cars[j][0];
                    var s2 = cars[j][1];
                    // if the prev car is faster
                    // or
                    // crash after the previous one and previous one crashed
                    if (s <= s2 || 1.0 * (p2 - p) / (s - s2) >= res[j] && res[j] > 0)
                        stack.Pop();
                    else
                        break;
                }
                if (stack.Any())
                {
                    int j = stack.Peek();
                    var p2 = cars[j][0];
                    var s2 = cars[j][1];
                    res[i] = 1.0 * (p2 - p) / (s - s2);
                }
                stack.Push(i);
            }
            return res;
        }
    }
}

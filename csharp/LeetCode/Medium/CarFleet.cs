namespace LeetCode.Medium.CarFleet
{
    using System;

    public class Solution
    {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            var cars = new (int, int)[position.Length];
            for (var i = 0; i < cars.Length; i++)
            {
                cars[i] = (position[i], speed[i]);
            }
            Array.Sort(cars, (x, y) => y.Item1 - x.Item1);

            double time = -1;
            var result = 0;
            for (var i = 0; i < cars.Length; i++)
            {
                var (p, s) = cars[i];
                if (s == 0) break;
                double newTime = 1.0 * (target - p) / s;
                if (newTime > time)
                {
                    result++;
                    time = newTime;
                }
            }
            return result;
        }
    }
}

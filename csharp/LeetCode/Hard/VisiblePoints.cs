namespace LeetCode.Hard.VisiblePoints
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        public int VisiblePoints(IList<IList<int>> points, int angle, IList<int> location)
        {
            var angles = new List<double>();

            var locationPoints = 0;
            foreach (var p in points)
            {
                var x = p[0] - location[0];
                var y = p[1] - location[1];
                if (x == 0 && y == 0)
                {
                    locationPoints++;
                    continue;
                }
                var d = Math.Atan2(y, x) * 180 / Math.PI;
                angles.Add(d);
            }
            angles.Sort();
            var k = angles.Count;
            for (var i = 0; i < k; i++)
            {
                if (angles[i] < 0) angles.Add(angles[i] + 360);
            }
            var l = 0;
            var result = 0;
            for (var r = 0; r < angles.Count; r++)

            {
                while (angles[r] - angles[l] > angle)
                {
                    l++;
                }
                result = Math.Max(result, r - l + 1);
            }

            return result + locationPoints;
        }
    }
}

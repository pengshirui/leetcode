namespace LeetCode.Medium.IsRobotBounded
{
    public class Solution
    {
        int[][] Directions = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
        };

        public bool IsRobotBounded(string instructions)
        {
            var x = 0;
            var y = 0;
            var i = 0;
            foreach (var cmd in instructions)
            {
                if (cmd == 'L')
                {
                    i = (i + 3) % 4;
                }
                else if (cmd == 'R')
                {
                    i = (i + 1) % 4;
                }
                else
                {
                    x += Directions[i][0];
                    y += Directions[i][1];
                }
            }
            return x == 0 && y == 0 || i > 0;
        }
    }
}

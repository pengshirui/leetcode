namespace LeetCode.Medium.CanCompleteCircuit
{
    public class Solution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            var totalTank = 0;
            var curTank = 0;
            var start = 0;
            for (var i = 0; i < gas.Length; i++)
            {
                totalTank += (gas[i] - cost[i]);
                curTank += (gas[i] - cost[i]);
                if (curTank < 0)
                {
                    start = i + 1;
                    curTank = 0;
                }
            }
            return totalTank >= 0 ? start : -1;
        }
    }
}

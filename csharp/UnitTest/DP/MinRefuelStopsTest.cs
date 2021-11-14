namespace UnitTest.DP
{
    using FluentAssertions;
    using LeetCode.DP.MinRefuelStops;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MinRefuelStopsTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {

            int[][] s = 
            { 
                new int[] { 10, 60 },
                new int[] { 20, 30 },
                new int[] { 30, 30 },
                new int[] { 60, 40 },
             };
            Solution.MinRefuelStops(100, 10, s).Should().Be(2);
        }
    }
}

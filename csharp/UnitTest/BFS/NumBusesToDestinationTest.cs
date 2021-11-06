namespace UnitTest.BFS
{
    using FluentAssertions;
    using LeetCode.BFS.NumBusesToDestination;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NumBusesToDestinationTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var g1 = new int[][]
            {
                new int[] { 1, 2, 7 },
                new int[] { 3, 6, 7 },
            };
            Solution.NumBusesToDestination(g1, 1, 6).Should().Be(2);
        }

        [TestMethod]
        public void Test2()
        {
            var g1 = new int[][]
            {
                new int[] { 1, 2, 7 },
                new int[] { 3, 6, 7 },
            };
            Solution.NumBusesToDestination(g1, 1, 9).Should().Be(-1);
        }
    }
}

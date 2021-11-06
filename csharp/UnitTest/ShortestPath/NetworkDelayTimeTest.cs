namespace UnitTest.ShortestPath
{
    using FluentAssertions;
    using LeetCode.ShortestPath.NetworkDelayTime;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NetworkDelayTimeTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var graph = new int[][]
            {
                new int[] { 1, 2, 1 },
                new int[] { 2, 1, 3 },
            };

            Solution.NetworkDelayTime(graph, 2, 2).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            var graph = new int[][]
            {
                new int[] { 3, 4, 1 },
                new int[] { 2, 1, 1 },
                new int[] { 2, 3, 1 },
            };

            Solution.NetworkDelayTime(graph, 4, 2).Should().Be(2);
        }

        [TestMethod]
        public void Test3()
        {
            var graph = new int[][]
            {
                new int[] { 1, 2, 1 },
                new int[] { 2, 3, 2 },
                new int[] { 1, 3, 4 },
            };

            Solution.NetworkDelayTime(graph, 3, 1).Should().Be(3);
        }
    }
}

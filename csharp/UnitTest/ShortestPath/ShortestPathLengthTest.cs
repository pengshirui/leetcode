namespace UnitTest.ShortestPath
{
    using FluentAssertions;
    using LeetCode.ShortestPath.ShortestPathLength;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ShortestPathLengthTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var g1 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 0 },
                new int[] { 0 },
                new int[] { 0 },
            };
            Solution.ShortestPathLength(g1).Should().Be(4);
        }
    }
}

namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.ShortestPath;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ShortestPathTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var m = new int[][]
            {
                new int[] { 0,0,0 },
                new int[] { 1,1,0 },
                new int[] { 0,0,0 },
                new int[] { 0,1,1 },
                new int[] { 0,0,0 },
            };

            Solution.ShortestPath(m, 1).Should().Be(6);
        }
    }
}

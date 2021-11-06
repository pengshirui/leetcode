namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.LargestIsland;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LargestIslandTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var matrix = new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 0, 1 },
            };
            Solution.LargestIsland(matrix).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            var matrix = new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 1, 0 },
            };
            Solution.LargestIsland(matrix).Should().Be(4);
        }
    }
}

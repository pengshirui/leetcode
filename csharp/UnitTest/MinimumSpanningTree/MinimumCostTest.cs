namespace UnitTest.MinimumSpanningTree
{
    using FluentAssertions;
    using LeetCode.MinimumSpanningTree.MinimumCost;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MinimumCostTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var flights = new int[][]
            {
                new int[]{ 1, 2, 5 },
                new int[]{ 1, 3, 6 },
                new int[]{ 2, 3, 1 },
            };
            Solution.MinimumCost(3, flights).Should().Be(6);
        }
    }
}

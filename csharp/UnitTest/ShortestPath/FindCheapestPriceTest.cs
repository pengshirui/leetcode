namespace UnitTest.ShortestPath
{
    using FluentAssertions;
    using LeetCode.ShortestPath.FindCheapestPrice;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindCheapestPriceTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var flights = new int[][]
            {
                new int[]{ 0, 1, 100 },
                new int[]{ 1, 2, 100 },
                new int[]{ 0, 2, 500 },
            };
            Solution.FindCheapestPrice(3, flights, 0, 2, 0).Should().Be(500);
        }

        [TestMethod]
        public void Test2()
        {
            var flights = new int[][]
            {
                new int[]{ 1, 2, 100 },
                new int[]{ 0, 1, 100 },
                new int[]{ 0, 2, 500 },
            };
            Solution.FindCheapestPrice(3, flights, 0, 2, 1).Should().Be(200);
        }
    }
}

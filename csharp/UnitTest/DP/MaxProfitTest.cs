namespace UnitTest.DP
{
    using FluentAssertions;
    using LeetCode.DP.MaxProfit;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MaxProfitTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.MaxProfit(3, 3, 5, 0, 0, 3, 1, 4).Should().Be(6);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.MaxProfit(1, 2, 4, 2, 5, 7, 2, 4, 9, 0).Should().Be(13);
        }
    }
}

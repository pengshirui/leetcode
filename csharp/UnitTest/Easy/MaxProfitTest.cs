namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MaxProfitTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            _solution.MaxProfit(7, 1, 5, 3, 6, 4).Should().Be(5);
        }

        [TestMethod]
        public void Test2()
        {
            _solution.MaxProfit(7, 6, 4, 3, 1).Should().Be(0);
        }
    }
}

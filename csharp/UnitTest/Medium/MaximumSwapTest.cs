namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.MaximumSwap;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MaximumSwapTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.MaximumSwap(9973).Should().Be(9973);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.MaximumSwap(1993).Should().Be(9913);
        }
    }
}

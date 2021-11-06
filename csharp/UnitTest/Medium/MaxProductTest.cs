namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.MaxProduct;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MaxProductTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.MaxProduct(2, 3, -2, 4).Should().Be(6);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.MaxProduct(2, -5, -2, -4, 3).Should().Be(24);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.MaxProduct(2, -5, 0, -4, 3).Should().Be(3);
        }
    }
}

namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.ProductExceptSelf;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProductExceptSelfTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { -1, 1, 0, -3, 3 };
            Solution.ProductExceptSelf(nums).Should().Equal(0, 0, 9, 0, 0);
        }

        [TestMethod]
        public void Test2()
        {
            var nums = new int[] { 1, 2, 4, 6 };
            Solution.ProductExceptSelf(nums).Should().Equal(48, 24, 12, 8);
        }
    }
}

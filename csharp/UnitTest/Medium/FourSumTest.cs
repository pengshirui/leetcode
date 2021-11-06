namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.FourSum;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FourSumTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { 1, 0, -1, 0, -2, 2 };
            Solution.FourSum(nums, 0).Should().HaveCount(3);
        }


        [TestMethod]
        public void Test2()
        {
            var nums = new int[] { 2, 2, 2, 2 };
            Solution.FourSum(nums, 8).Should().HaveCount(1);
        }

        [TestMethod]
        public void Test3()
        {
            var nums = new int[] { 2, 2, 2, 2, 2 };
            Solution.FourSum(nums, 8).Should().HaveCount(1);
        }

        [TestMethod]
        public void Test4()
        {
            var nums = new int[] { 2, 2, 2, 2, 2, 2, 2 };
            Solution.FourSum(nums, 8).Should().HaveCount(1);
        }

        [TestMethod]
        public void Test5()
        {
            var nums = new int[] { 0, 0, 0, 0 };
            Solution.FourSum(nums, 0).Should().HaveCount(1);
        }

        [TestMethod]
        public void Test6()
        {
            var nums = new int[] { 1, -2, -5, -4, -3, 3, 3, 5 };
            Solution.FourSum(nums, -11).Should().HaveCount(1);
        }
    }
}

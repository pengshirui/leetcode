namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindTargetSumWaysTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { 1, 1, 1, 1, 1 };
            _solution.FindTargetSumWays(nums, 3).Should().Be(5);
        }

        [TestMethod]
        public void Test2()
        {
            var nums = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            _solution.FindTargetSumWays(nums, 1).Should().Be(256);
        }

        [TestMethod]
        public void Test3()
        {
            var nums = new int[] { 1, 0 };
            _solution.FindTargetSumWays(nums, 1).Should().Be(2);
        }

        [TestMethod]
        public void Test4()
        {
            var nums = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            _solution.FindTargetSumWays(nums, 1).Should().Be(256);
        }
    }
}

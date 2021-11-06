namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CheckSubarraySumTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { 23, 2, 4, 6, 6 };
            var k = 7;
            _solution.CheckSubarraySum(nums, k).Should().BeTrue();
        }
    }
}

namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.SubarraySum;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SubarraySumTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[1];
            Solution.SubarraySum(nums, 0).Should().Be(1);
        }

        [TestMethod]
        public void Test2()
        {
            var nums = new int[10];
            Solution.SubarraySum(nums, 0).Should().Be(55);
        }

        [TestMethod]
        public void Test3()
        {
            var nums = new int[100];
            Solution.SubarraySum(nums, 0).Should().Be(5050);
        }

        [TestMethod]
        public void Test4()
        {
            var nums = new int[3] { 1, 1, 1 };
            Solution.SubarraySum(nums, 2).Should().Be(2);
        }
    }
}

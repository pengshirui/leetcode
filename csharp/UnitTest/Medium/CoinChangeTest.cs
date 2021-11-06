namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CoinChangeTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { 1, 2, 5 };
            var k = 11;
            Solution.CoinChange(nums, k).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            var nums = new int[] { 186, 419, 83, 408 };
            var k = 6249;
            Solution.CoinChange(nums, k).Should().Be(20);
        }

    }
}

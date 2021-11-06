namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.MaxArea;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MaxAreaTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var g = new int[] { 1, 1 };
            Solution.MaxArea(g).Should().Be(1);
        }

        [TestMethod]
        public void Test2()
        {
            var g = new int[] { 4, 3, 2, 1, 4 };
            Solution.MaxArea(g).Should().Be(16);
        }

        [TestMethod]
        public void Test3()
        {
            var g = new int[] { 1, 2, 1 };
            Solution.MaxArea(g).Should().Be(2);
        }
    }
}

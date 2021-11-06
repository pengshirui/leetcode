namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.MinimumJumps;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MinimumJumpsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var forbidden = new int[] { 14, 4, 18, 1, 15 };
            var a = 3;
            var b = 15;
            var x = 9;
            Solution.MinimumJumps(forbidden, a, b, x).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            var forbidden = new int[] { 8, 3, 16, 6, 12, 20 };
            var a = 15;
            var b = 13;
            var x = 11;
            Solution.MinimumJumps(forbidden, a, b, x).Should().Be(-1);
        }
    }
}

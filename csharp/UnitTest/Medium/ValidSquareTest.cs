namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.ValidSquare;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ValidSquareTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var a = new int[] { 0, 0 };
            var b = new int[] { 1, 1 };
            var c = new int[] { 1, 0 };
            var d = new int[] { 0, 1 };
            Solution.ValidSquare(a, b, c, d).Should().BeTrue();
        }

    }
}

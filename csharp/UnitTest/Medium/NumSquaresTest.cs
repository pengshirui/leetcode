namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.NumSquares;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NumSquaresTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.NumSquares(1).Should().Be(1);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.NumSquares(12).Should().Be(3);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.NumSquares(13).Should().Be(2);
        }
    }
}

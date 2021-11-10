namespace UnitTest.DP
{
    using FluentAssertions;
    using LeetCode.DP.MinKnightMoves;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MinKnightMovesTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.MinKnightMoves(5, 5).Should().Be(6);
        }
    }
}

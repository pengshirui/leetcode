namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.CountSquares;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CountSquaresTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var m = new int[][]
            {
                new int[] { 0, 1, 1, 1 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 0, 1, 1, 1 },
            };

            Solution.CountSquares(m).Should().Be(15);
        }

    }
}

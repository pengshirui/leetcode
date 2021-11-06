namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.MaxPoints;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MaxPointsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            int[][] m =
            {
                new int[] { 1, 2, 3 },
                new int[] { 1, 5, 1 },
                new int[] { 3, 1, 1 }
            };
            Solution.MaxPoints(m).Should().Be(9);
        }

        [TestMethod]
        public void Test2()
        {
            int[][] m =
            {
                new int[] { 4, 1, 0, 4, 0 },
                new int[] { 1, 0, 4, 0, 5 },
                new int[] { 1, 3, 0, 4, 1 },
                new int[] { 4, 4, 0, 4, 0 }
            };
            Solution.MaxPoints(m).Should().Be(15);
        }
    }
}

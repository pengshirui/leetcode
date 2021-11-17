namespace UnitTest.DP
{
    using FluentAssertions;
    using LeetCode.DP.UniquePathsWithObstacles;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UniquePathsWithObstaclesTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            int[][] m =
            {
                new int[]{ 0, 0, 0 },
                new int[]{ 0, 1, 0 },
                new int[]{ 0, 0, 0 },
            };
            Solution.UniquePathsWithObstacles(m).Should().Be(2);
        }


        [TestMethod]
        public void Test2()
        {
            int[][] m =
            {
                new int[]{ 1 },
            };
            Solution.UniquePathsWithObstacles(m).Should().Be(0);
        }
    }
}

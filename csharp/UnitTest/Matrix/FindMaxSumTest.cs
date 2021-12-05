namespace UnitTest.Matrix
{
    using FluentAssertions;
    using LeetCode.Matrix.FindMaxSum;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindMaxSumTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            int[][] b =
            {
                new int[]{ 0, 0, 0, 0, 0 },
                new int[]{ 0, 0, 1, 0, 0 },
                new int[]{ 0, 1, 1, 1, 0 },
                new int[]{ 1, 1, 1, 1, 1 },
                new int[]{ 0, 1, 1, 1, 0 },
                new int[]{ 0, 0, 1, 0, 0 },
                new int[]{ 0, 0, 0, 0, 0 },
                new int[]{ 0, 0, 0, 0, 0 },
            };
            Solution.FindMaxSum2(b, 2).Should().Equal(13, 8, 8);
        }
    }
}
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
            Solution.FindMaxSum(b, 2).Should().Equal(13, 8, 8);
        }

        [TestMethod]
        public void Test2()
        {
            int[][] b =
            {
                new int[]{ 1,2,3,9,0 },
                new int[]{ 0,1,2,3,5 },
                new int[]{ 3,4,5,6,7 },
                new int[]{ 1,2,3,4,5 },
                new int[]{ 2,3,4,1,6 },
            };
            Solution.FindMaxSum(b, 2).Should().Equal(47, 0, 0);
        }
    }
}
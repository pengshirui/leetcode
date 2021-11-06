namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LongestIncreasingPathTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var matrix = new int[][]
            {
                new int[] { 9, 9, 4 },
                new int[] { 6, 6, 8 },
                new int[] { 2, 1, 1 },
            };
            _solution.LongestIncreasingPath(matrix).Should().Be(4);
        }
    }
}

namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.SlidingPuzzle;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SlidingPuzzleTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var g1 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 0, 5 },
            };
            Solution.SlidingPuzzle(g1).Should().Be(1);
        }

        [TestMethod]
        public void Test2()
        {
            var g1 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 5, 4, 0 },
            };
            Solution.SlidingPuzzle(g1).Should().Be(-1);
        }
    }
}

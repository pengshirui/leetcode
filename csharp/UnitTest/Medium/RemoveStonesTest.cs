namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RemoveStonesTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var stones = new int[][]
            {
                new int[] { 0, 0 },
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { 1, 2 },
                new int[] { 2, 1 },
                new int[] { 2, 2 },
            };
            _solution.RemoveStones(stones).Should().Be(5);
        }

        [TestMethod]
        public void Test2()
        {
            var stones = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { 1, 1 },
            };
            _solution.RemoveStones(stones).Should().Be(2);
        }
    }
}

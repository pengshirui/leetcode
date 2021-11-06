namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MaxDistanceTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var g = new int[3][]
            {
                new int[] { 1, 0, 1 },
                new int[] { 0, 0, 0 },
                new int[] { 1, 0, 1 },
            };
            _solution.MaxDistance(g).Should().Be(2);

        }

        [TestMethod]
        public void Test2()
        {
            var g = new int[2][]
            {
                new int[] { 1,0 },
                new int[] { 0,0 },
            };
            _solution.MaxDistance(g).Should().Be(2);

        }

        [TestMethod]
        public void Test3()
        {
            var g = new int[1][]
            {
                new int[] { 1 },
            };
            _solution.MaxDistance(g).Should().Be(-1);

        }
    }
}

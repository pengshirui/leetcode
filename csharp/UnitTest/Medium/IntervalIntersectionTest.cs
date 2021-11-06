namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IntervalIntersectionTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var l1 = new int[][]
            {
                new int[] { 0, 2 },
                new int[] { 5, 10 },
            };
            var l2 = new int[][]
            {
                new int[] { 1, 5 },
                new int[] { 8, 12 },
            };
            _solution.IntervalIntersection(l1, l2).Should().HaveCount(3);
        }

        [TestMethod]
        public void Test2()
        {
            var l1 = new int[][]
            {
                new int[] { 10, 12 },
                new int[] { 18, 19 },
            };
            var l2 = new int[][]
            {
                new int[] { 1, 6 },
                new int[] { 8, 11 },
                new int[] { 13, 17 },
                new int[] { 19, 20 },
            };
            _solution.IntervalIntersection(l1, l2).Should().HaveCount(2);
        }
    }
}

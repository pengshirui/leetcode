namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class KClosestTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var points = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { -2, 2 }
            };
            var k = 1;

            Solution.KClosest(points, k).Should().HaveCount(1);
        }

        [TestMethod]
        public void Test2()
        {
            var points = new int[][]
            {
                new int[] { 3,3 },
                new int[] { 5,-1 },
                new int[] { -2, 4 }
            };
            var k = 2;

            Solution.KClosest(points, k).Should().HaveCount(2);
        }
    }
}

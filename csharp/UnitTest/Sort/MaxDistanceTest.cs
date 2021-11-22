namespace UnitTest.Sort
{
    using FluentAssertions;
    using LeetCode.Sort.MaxDistance;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MaxDistanceTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            int[] n = { 1, 2, 3, 4, 7 };
            var k = 3;
            Solution.MaxDistance(n, k).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            int[] n = { 5, 4, 3, 2, 1, 1000000000 };
            var k = 2;
            Solution.MaxDistance(n, k).Should().Be(999999999);
        }
    }
}

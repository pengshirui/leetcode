namespace UnitTest.BinarySearch
{
    using FluentAssertions;
    using LeetCode.BinarySearch.MinEatingSpeed;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MinEatingSpeedTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            int[] n = { 3, 6, 7, 11 };
            var h = 8;
            Solution.MinEatingSpeed(n, h).Should().Be(4);
        }
    }
}

namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ThreeSumClosetTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums1 = new int[] { -1, 2, 1, -4 };
            _solution.ThreeSumClosest(nums1, 1).Should().Be(2);
        }

        [TestMethod]
        public void Test2()
        {
            var nums1 = new int[] { 1, 2, 4, 8, 16, 32, 64, 128 };
            _solution.ThreeSumClosest(nums1, 82).Should().Be(82);
        }
    }
}

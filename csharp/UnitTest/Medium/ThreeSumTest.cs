namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.ThreeSum;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ThreeSumTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums1 = new int[] { -1, 0, 1, 2, -1, -4 };
            Solution.ThreeSum(nums1).Should().HaveCount(2);
        }

        [TestMethod]
        public void Test2()
        {
            var nums2 = new int[] { };
            Solution.ThreeSum(nums2).Should().HaveCount(0);
        }

        [TestMethod]
        public void Test3()
        {
            var nums3 = new int[] { 0 };
            Solution.ThreeSum(nums3).Should().HaveCount(0);
        }

        [TestMethod]
        public void Test4()
        {
            var nums3 = new int[] { 0, 0, 0, 0 };
            var r = Solution.ThreeSum(nums3);
            r.Should().HaveCount(1);
            r[0].Should().Equal(0, 0, 0);
        }
    }
}

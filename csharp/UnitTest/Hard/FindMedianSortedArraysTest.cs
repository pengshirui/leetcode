namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.FindMedianSortedArrays;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindMedianSortedArraysTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums1 = new int[] { 1, 3 };
            var nums2 = new int[] { 2 };
            Solution.FindMedianSortedArrays(nums1, nums2).Should().Be(2);
        }

        [TestMethod]
        public void Test2()
        {
            var nums1 = new int[] { 1, 3 };
            var nums2 = new int[] { 2, 4 };
            Solution.FindMedianSortedArrays(nums1, nums2).Should().Be(2.5);
        }

        [TestMethod]
        public void Test3()
        {
            var nums1 = new int[] { 2 };
            var nums2 = new int[] { 1 };
            Solution.FindMedianSortedArrays(nums1, nums2).Should().Be(1.5);
        }
    }
}

namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MergeTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var nums2 = new int[] { 2, 5, 6 };
            _solution.Merge(nums1, 3, nums2, 3);
            nums1.Should().Equal(1, 2, 2, 3, 5, 6 );
        }

        [TestMethod]
        public void Test2()
        {
            var nums1 = new int[] { 1 };
            var nums2 = new int[] { };
            _solution.Merge(nums1, 1, nums2, 0);
            nums1.Should().Equal(1);
        }

        [TestMethod]
        public void Test3()
        {
            var nums1 = new int[] { 0 };
            var nums2 = new int[] { 1 };
            _solution.Merge(nums1, 0, nums2, 1);
            nums1.Should().Equal(new int[] { 1 });
        }
    }
}

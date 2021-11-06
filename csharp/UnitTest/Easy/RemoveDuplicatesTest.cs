namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RemoveDuplicatesTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums1 = new int[] { 1, 1, 2 };
            _solution.RemoveDuplicates(nums1).Should().Be(2);
        }

        [TestMethod]
        public void Test2()
        {
            var nums2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            _solution.RemoveDuplicates(nums2).Should().Be(5);
        }

        [TestMethod]
        public void Test3()
        {
            var nums3 = new int[] { };
            _solution.RemoveDuplicates(nums3).Should().Be(0);
        }

        [TestMethod]
        public void Test4()
        {
            var nums4 = new int[] { 1, 2, 3 };
            _solution.RemoveDuplicates(nums4).Should().Be(3);
        }
    }
}

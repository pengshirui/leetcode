namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MoveZeroesTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums1 = new int[] { 1, 2, 0, 0, 3, 4, 5 };
            _solution.MoveZeroes(nums1);
            var r1 = new int[] { 1, 2, 3, 4, 5, 0, 0 };
            nums1.Should().BeEquivalentTo(r1);
        }

        [TestMethod]
        public void Test2()
        {
            var nums2 = new int[] { 1, 0 };
            _solution.MoveZeroes(nums2);
            var r2 = new int[] { 1, 0 };
            nums2.Should().BeEquivalentTo(r2);
        }

        [TestMethod]
        public void Test3()
        {
            var nums3 = new int[] { 0 };
            _solution.MoveZeroes(nums3);
            var r3 = new int[] { 0 };
            nums3.Should().BeEquivalentTo(r3);
        }

        [TestMethod]
        public void Test4()
        {
            var nums4 = new int[] { 0, 1 };
            _solution.MoveZeroes(nums4);
            var r4 = new int[] { 0, 1 };
            nums4.Should().BeEquivalentTo(r4);
        }

    }
}

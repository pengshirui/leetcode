namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PlusOneTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums1 = new int[] { 1, 2, 0, 0, 3, 4, 5 };
            Solution.PlusOne(nums1).Should().Equal(1, 2, 0, 0, 3, 4, 6);
        }

        [TestMethod]
        public void Test2()
        {
            var nums2 = new int[] { 9 };
            Solution.PlusOne(nums2).Should().Equal(1, 0);
        }

        [TestMethod]
        public void Test3()
        {
            var nums3 = new int[] { 0 };
            Solution.PlusOne(nums3).Should().Equal(1);
        }
    }
}

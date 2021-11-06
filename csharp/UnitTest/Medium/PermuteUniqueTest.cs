namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PermuteUniqueTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { 1, 1, 3 };
            var result = Solution.PermuteUnique(nums);
            result.Should().HaveCount(3);
        }

        [TestMethod]
        public void Test2()
        {
            var nums = new int[] { 1, 2 };
            Solution.PermuteUnique(nums).Should().HaveCount(2);
        }

        [TestMethod]
        public void Test3()
        {
            var nums = new int[] { 1 };
            Solution.PermuteUnique(nums).Should().HaveCount(1);
        }
    }
}

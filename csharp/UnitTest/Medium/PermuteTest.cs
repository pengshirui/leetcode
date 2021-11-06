namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PermuteTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { 1, 2, 3 };
            var result = Solution.Permute(nums);
            result.Should().HaveCount(6);
        }

        [TestMethod]
        public void Test2()
        {
            var nums = new int[] { 1, 2 };
            Solution.Permute(nums).Should().HaveCount(2);
        }

        [TestMethod]
        public void Test3()
        {
            var nums = new int[] { 1 };
            Solution.Permute(nums).Should().HaveCount(1);
        }
    }
}

namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SubsetsTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[]
            {
                1, 2, 3
            };
            _solution.Subsets(nums).Should().HaveCount(8);
        }

        [TestMethod]
        public void Test2()
        {
            var nums = new int[]
            {
                1, 2
            };
            _solution.Subsets(nums).Should().HaveCount(4);
        }
    }
}

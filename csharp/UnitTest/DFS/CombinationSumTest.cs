namespace UnitTest.DFS
{
    using FluentAssertions;
    using LeetCode.DFS.CombinationSum;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CombinationSumTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { 2, 3, 5 };
            var k = 8;
            Solution.CombinationSum(nums, k).Should().HaveCount(3);
        }

        [TestMethod]
        public void Test2()
        {
            var nums = new int[] { 2, 3, 6, 7 };
            var k = 7;
            var r = Solution.CombinationSum(nums, k);
            r.Should().HaveCount(2);
            r[0].Should().Equal(2, 2, 3);
            r[1].Should().Equal(7);
        }
    }
}

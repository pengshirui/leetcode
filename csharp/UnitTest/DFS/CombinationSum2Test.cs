namespace UnitTest.DFS
{
    using FluentAssertions;
    using LeetCode.DFS.CombinationSum2;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CombinationSum2Test
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { 10, 1, 2, 7, 6, 1, 5 };
            var t = 8;
            Solution.CombinationSum2(nums, t).Should().HaveCount(4);
        }
    }
}

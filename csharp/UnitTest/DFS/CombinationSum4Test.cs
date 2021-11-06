namespace UnitTest.DFS
{
    using FluentAssertions;
    using LeetCode.DFS.CombinationSum4;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CombinationSum4Test
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { 1, 2, 3 };
            var t = 4;
            Solution.CombinationSum4(nums, t).Should().Be(7);
        }

        [TestMethod]
        public void Test2()
        {
            var nums = new int[] { 1, 2, 3 };
            var t = 4;
            Solution.CombinationSum4DP(nums, t).Should().Be(7);
        }

        [TestMethod]
        public void Test4()
        {
            var nums = new int[] { 1, 2, 3 };
            var t = 15;
            Solution.CombinationSum4DP(nums, t).Should().Be(5768);
        }
    }
}

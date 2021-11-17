namespace UnitTest.DP
{
    using FluentAssertions;
    using LeetCode.DP.UniquePaths;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UniquePathsTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.UniquePaths(3, 2).Should().Be(3);
        }
    }
}

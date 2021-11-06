namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.UniquePaths;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UniquePathsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.UniquePaths(3, 2).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.UniquePaths(7, 3).Should().Be(28);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.UniquePaths(5, 5).Should().Be(70);
        }

        [TestMethod]
        public void Test4()
        {
            Solution.UniquePaths(30, 30).Should().Be(51542064);
        }
    }
}

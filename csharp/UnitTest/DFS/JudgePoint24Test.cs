namespace UnitTest.DFS
{
    using FluentAssertions;
    using LeetCode.DFS.JudgePoint24;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class JudgePoint24Test
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.JudgePoint24(4, 1, 8, 7).Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            Solution.JudgePoint24(1, 9, 1, 2).Should().BeTrue();
        }
    }
}

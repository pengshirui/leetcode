namespace UnitTest.DFS
{
    using FluentAssertions;
    using LeetCode.DFS.GenerateParenthesis;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GenerateParenthesisTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.GenerateParenthesis(1).Should().HaveCount(1);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.GenerateParenthesis(3).Should().HaveCount(5);
        }
    }
}

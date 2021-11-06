namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.SolveNQueens;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SolveNQueensTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.SolveNQueens(1).Should().HaveCount(1);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.SolveNQueens(2).Should().BeEmpty();
        }

        [TestMethod]
        public void Test3()
        {
            Solution.SolveNQueens(3).Should().BeEmpty();
        }

        [TestMethod]
        public void Test4()
        {
            Solution.SolveNQueens(4).Should().HaveCount(2);
        }
    }
}

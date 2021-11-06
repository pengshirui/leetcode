namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ExistTest
    {
        private readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var board = new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' },
            };

            var word = "ABCCED";

            _solution.Exist(board, word).Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            var board = new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' },
            };

            var word = "SEE";

            _solution.Exist(board, word).Should().BeTrue();
        }

        [TestMethod]
        public void Test3()
        {
            var board = new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' },
            };

            var word = "ABCB";

            _solution.Exist(board, word).Should().BeFalse();
        }
    }
}

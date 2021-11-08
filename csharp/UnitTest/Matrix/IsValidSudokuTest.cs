namespace UnitTest.Matrix
{
    using FluentAssertions;
    using LeetCode.Matrix.IsValidSudoku;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IsValidSudokuTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            char[][] b =
            {
                new char[]{'8','3','.','.','7','.','.','.','.'},
                new char[]{'6','.','.','1','9','5','.','.','.'},
                new char[]{'.','9','8','.','.','.','.','6','.'},
                new char[]{'8','.','.','.','6','.','.','.','3'},
                new char[]{'4','.','.','8','.','3','.','.','1'},
                new char[]{'7','.','.','.','2','.','.','.','6'},
                new char[]{'.','6','.','.','.','.','2','8','.'},
                new char[]{'.','.','.','4','1','9','.','.','5'},
                new char[]{'.','.','.','.','8','.','.','7','9'},
            };
            Solution.IsValidSudoku(b).Should().BeFalse();
        }
    }
}
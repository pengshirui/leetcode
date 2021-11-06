namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;


    [TestClass]
    public class NumMatrixTest
    {
        [TestMethod]
        public void Test1()
        {
            var grid1 = new int[3][]
            {
                new int[3] { 1, 1, 1 },
                new int[3] { 1, 1, 1 },
                new int[3] { 1, 1, 1 },
            };

            var matrix = new NumMatrix(grid1);

            matrix.SumRegion(0, 0, 2, 2).Should().Be(9);
            matrix.SumRegion(1, 1, 2, 2).Should().Be(4);
        }
    }
}

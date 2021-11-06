namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.SearchMatrix;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SearchMatrixTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var m = new int[][]
            {
                new int[] { -1, 3 },
            };

            Solution.SearchMatrix(m, 3).Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            var m = new int[][]
            {
                new int[] { -1 },
            };

            Solution.SearchMatrix(m, -1).Should().BeTrue();
        }

    }
}

namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CutOffTreeTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var forest = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 0, 0, 4 },
                new int[] { 7, 6, 5 },
            };

            _solution.CutOffTree(forest).Should().Be(6);
        }

        [TestMethod]
        public void Test2()
        {
            var forest = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 0, 0, 0 },
                new int[] { 7, 6, 5 },
            };

            _solution.CutOffTree(forest).Should().Be(-1);
        }

        [TestMethod]
        public void Test3()
        {
            var forest = new int[][]
            {
                new int[] { 2, 3, 5 },
                new int[] { 0, 0, 7 },
                new int[] { 1, 4, 6 },
            };

            _solution.CutOffTree(forest).Should().Be(11);
        }


        [TestMethod]
        public void Test4()
        {
            var forest = new int[][]
            {
                new int[] { 4, 2, 3 },
                new int[] { 0, 0, 1 },
                new int[] { 7, 6, 5 },
            };

            _solution.CutOffTree(forest).Should().Be(10);
        }
    }
}

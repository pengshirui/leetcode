namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.BinarySearch.BinarySearch;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BinarySearchTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var l = new int[] { 1, 2, 4 };
            var t = 3;
            Solution.LowerBound(l, t).Should().Be(1);
        }

        [TestMethod]
        public void Test2()
        {
            var l = new int[] { 1, 2 };
            var t = 3;
            Solution.LowerBound(l, t).Should().Be(1);
        }

        [TestMethod]
        public void Test3()
        {
            var l = new int[] { 1, 2, 3 };
            var t = 3;
            Solution.LowerBound(l, t).Should().Be(1);
        }

        [TestMethod]
        public void Test4()
        {
            var l = new int[] { 1, 2, 3, 3 };
            var t = 3;
            Solution.LowerBound(l, t).Should().Be(1);
        }

        [TestMethod]
        public void Test5()
        {
            var l = new int[] { 3, 3 };
            var t = 3;
            Solution.LowerBound(l, t).Should().Be(0);
        }
    }
}

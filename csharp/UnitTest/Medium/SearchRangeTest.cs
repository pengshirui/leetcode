namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.SearchRange;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SearchRangeTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var l = new int[] { 1, 2, 3, 4 };

            Solution.SearchRange(l, 2).Should().Equal(1, 1);
        }

        [TestMethod]
        public void Test2()
        {
            var l = new int[] { 1, 2, 2, 5 };

            Solution.SearchRange(l, 2).Should().Equal(1, 2);
        }

        [TestMethod]
        public void Test3()
        {
            var l = new int[] { 1, 2, 2, 5 };

            Solution.SearchRange(l, 3).Should().Equal(-1, -1);
        }

        [TestMethod]
        public void Test4()
        {
            var l = new int[] { 1 };

            Solution.SearchRange(l, 1).Should().Equal(0, 0);
        }

        [TestMethod]
        public void Test5()
        {
            var l = new int[] { 1, 1 };

            Solution.SearchRange(l, 1).Should().Equal(0, 1);
        }

        [TestMethod]
        public void Test6()
        {
            var l = new int[] { 1, 2, 3 };

            Solution.SearchRange(l, 2).Should().Equal(1, 1);
        }
    }
}

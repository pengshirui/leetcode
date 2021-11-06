namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SearchTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var l = new int[] { 1, 2, 3, 4 };

            Solution.Search(l, 2).Should().Be(1);
        }

        [TestMethod]
        public void Test2()
        {
            var l = new int[] { 1, 2, 3, 5 };

            Solution.Search(l, 4).Should().Be(-1);
        }
    }
}

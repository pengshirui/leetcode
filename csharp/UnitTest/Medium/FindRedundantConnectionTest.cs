namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindRedundantConnectionTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var g = new int[3][]
            {
                new int[]{ 1, 2 },
                new int[]{ 1, 3 },
                new int[]{ 2, 3 },
            };
            _solution.FindRedundantConnection(g).Should().Equal(2, 3);
        }

        [TestMethod]
        public void Test2()
        {
            var g = new int[5][]
            {
                new int[]{ 1, 2 },
                new int[]{ 2, 3 },
                new int[]{ 3, 4 },
                new int[]{ 1, 4 },
                new int[]{ 1, 5 },
            };
            _solution.FindRedundantConnection(g).Should().Equal(1, 4);
        }
    }
}

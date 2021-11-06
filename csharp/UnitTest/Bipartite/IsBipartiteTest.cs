namespace UnitTest.Bipartite
{
    using FluentAssertions;
    using LeetCode.Bipartite.IsBipartite;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IsBipartiteTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var g = new int[4][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 0, 2 },
                new int[] { 0, 1, 3 },
                new int[] { 0, 2 },
            };
            Solution.IsBipartite(g).Should().BeFalse();
        }

        [TestMethod]
        public void Test2()
        {
            var g = new int[5][]
            {
                new int[] { 4 },
                new int[] { },
                new int[] { 4 },
                new int[] { 4 },
                new int[] { 0, 2, 3 },
            };
            Solution.IsBipartite(g).Should().BeTrue();
        }

        [TestMethod]
        public void Test3()
        {
            Solution.IsBipartite(null).Should().BeFalse();
        }
    }
}

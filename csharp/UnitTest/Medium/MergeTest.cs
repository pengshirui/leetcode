namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.Merge;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MergeTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var g = new int[3][]
            {
                new int[] { 0, 30 },
                new int[] { 5, 10 },
                new int[] { 15, 20 },
            };
            Solution.Merge(g)[0].Should().Equal(new int[] { 0, 30 });
        }

        [TestMethod]
        public void Test2()
        {
            var g = new int[2][]
            {
                new int[] { 0,1 },
                new int[] { 1,2 },
            };
            Solution.Merge(g)[0].Should().Equal(new int[] { 0, 2 });
        }

        [TestMethod]
        public void Test3()
        {
            var g = new int[2][]
            {
                new int[] { 0, 1 },
                new int[] { 2, 3 },
            };
            var res = Solution.Merge(g);
            res[0].Should().Equal(new int[] { 0, 1 });
            res[1].Should().Equal(new int[] { 2, 3 });
        }

        [TestMethod]
        public void Test4()
        {
            var g = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 2, 6 },
                new int[] { 8, 10 },
                new int[] { 15, 18 },
            };
            var res = Solution.Merge(g);
            res[0].Should().Equal(1, 6);
            res[1].Should().Equal(8, 10);
            res[2].Should().Equal(15, 18);

        }
    }
}

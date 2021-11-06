namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.Insert;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class InsertTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var intervals = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 6, 9 },
            };

            var newInterval = new int[] { 2, 5 };
            var r = Solution.Insert(intervals, newInterval);
            r[0].Should().Equal(1, 5);
            r[1].Should().Equal(6, 9);
        }

        [TestMethod]
        public void Test2()
        {
            var intervals = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 5 },
                new int[] { 6, 7 },
                new int[] { 8, 10 },
                new int[] { 12, 16 },
            };

            var newInterval = new int[] { 4, 8 };
            var r = Solution.Insert(intervals, newInterval);
            r[0].Should().Equal(1, 2);
            r[1].Should().Equal(3, 10);
            r[2].Should().Equal(12, 16);
        }

        [TestMethod]
        public void Test3()
        {
            var intervals = new int[][]
            {
            };

            var newInterval = new int[] { 4, 8 };
            var r = Solution.Insert(intervals, newInterval);
            r[0].Should().Equal(4, 8);
        }

        [TestMethod]
        public void Test4()
        {
            var intervals = new int[][]
            {
                new int[] { 4, 8 },
            };

            var newInterval = new int[] { 5, 6 };
            var r = Solution.Insert(intervals, newInterval);
            r[0].Should().Equal(4, 8);
        }

        [TestMethod]
        public void Test5()
        {
            var intervals = new int[][]
            {
                new int[] { 5, 6 },
            };

            var newInterval = new int[] { 4, 8 };
            var r = Solution.Insert(intervals, newInterval);
            r[0].Should().Equal(4, 8);
        }

        [TestMethod]
        public void Test6()
        {
            var intervals = new int[][]
            {
                new int[] { 1, 5 },
            };

            var newInterval = new int[] { 6, 8 };
            var r = Solution.Insert(intervals, newInterval);
            r[0].Should().Equal(1, 5);
            r[1].Should().Equal(6, 8);
        }
    }
}

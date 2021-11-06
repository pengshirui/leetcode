namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SumEvenAfterQueriesTesteSumTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { 1, 2, 3, 4 };
            var queries = new int[4][]
            {
                new int[] { 1, 0 },
                new int[] { -3, 1 },
                new int[] { -4, 0 },
                new int[] { 2, 3 },
            };

            _solution.SumEvenAfterQueries(nums, queries).Should().Equal(8, 6, 2, 4);
        }
    }
}

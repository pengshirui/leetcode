namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TopKFrequentTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { 1, 1, 1, 2, 2, 3 };
            var k = 2;
            _solution.TopKFrequent(nums, k).Should().Equal(1, 2);
        }

    }
}

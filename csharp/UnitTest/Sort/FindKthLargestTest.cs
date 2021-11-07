namespace UnitTest.Sort
{
    using FluentAssertions;
    using LeetCode.Sort.FindKthLargest;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindKthLargestTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            int[] n = { 3, 2, 1, 5, 6, 4 };
            var k = 2;
            Solution.FindKthLargest(n, k).Should().Be(5);
        }

        [TestMethod]
        public void Test2()
        {
            int[] n = { 3, 2, 1, 5, 6, 4 };
            var k = 6;
            Solution.FindKthLargest(n, k).Should().Be(1);
        }

        [TestMethod]
        public void Test3()
        {
            int[] n = { 3, 2, 1, 5, 6, 4 };
            var k = 1;
            Solution.FindKthLargest(n, k).Should().Be(6);
        }

        [TestMethod]
        public void Test4()
        {
            int[] n = { 1, 1, 1};
            var k = 1;
            Solution.FindKthLargest(n, k).Should().Be(1);
        }
    }
}

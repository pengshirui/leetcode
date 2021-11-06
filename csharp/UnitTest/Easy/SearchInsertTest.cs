namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy.SearchInsert;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SearchInsertTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { 1, 3, 5, 6 };
            Solution.SearchInsert2(nums, 5).Should().Be(2);
        }

        [TestMethod]
        public void Test2()
        {
            var nums = new int[] { 1, 3, 5, 6 };
            Solution.SearchInsert2(nums, 7).Should().Be(4);
        }

        [TestMethod]
        public void Test3()
        {
            var nums = new int[] { 1, 3, 5, 6 };
            Solution.SearchInsert2(nums, 2).Should().Be(1);
        }
    }
}

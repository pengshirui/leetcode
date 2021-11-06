namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.SplitArray;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SplitArrayTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var nums = new int[] { 7, 2, 5, 10, 8 };
            var m = 2;
            Solution.SplitArray(nums, m).Should().Be(18);
        }

        [TestMethod]
        public void Test2()
        {
            var nums = new int[] { 1, 2, 3 };
            var m = 1;
            Solution.SplitArray(nums, m).Should().Be(6);
        }

        [TestMethod]
        public void Test3()
        {
            var nums = new int[] { 1, 4, 4 };
            var m = 3;
            Solution.SplitArray(nums, m).Should().Be(4);
        }

        [TestMethod]
        public void Test4()
        {
            var nums = new int[] { 7, 2, 5, 10, 8 };
            var m = 2;
            Solution.SplitArray2(nums, m).Should().Be(18);
        }

        [TestMethod]
        public void Test5()
        {
            var nums = new int[] { 1, 2, 3 };
            var m = 1;
            Solution.SplitArray2(nums, m).Should().Be(6);
        }

        [TestMethod]
        public void Test6()
        {
            var nums = new int[] { 1, 4, 4 };
            var m = 3;
            Solution.SplitArray2(nums, m).Should().Be(4);
        }
    }
}

namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindMissingRangesTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var t1 = new int[] { 0, 1, 3, 50, 75 };
            _solution.FindMissingRanges(t1, 0, 99).Should().Equal("2", "4->49", "51->74", "76->99");
        }

        [TestMethod]
        public void Test2()
        {
            var t1 = new int[] { };
            _solution.FindMissingRanges(t1, 0, 99).Should().Equal("0->99");
        }

        [TestMethod]
        public void Test3()
        {
            var t1 = new int[] { };
            _solution.FindMissingRanges(t1, 0, 0).Should().Equal("0");
        }

        [TestMethod]
        public void Test4()
        {
            var t1 = new int[] { 0 };
            _solution.FindMissingRanges(t1, 0, 0).Should().Equal();
        }
    }
}

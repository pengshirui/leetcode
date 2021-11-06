namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindKthPositiveTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var t1 = new int[] { 2, 3, 4, 7 };
            Solution.FindKthPositive(t1, 5).Should().Be(9);
        }

        [TestMethod]
        public void Test2()
        {
            var t1 = new int[] { 2 };
            Solution.FindKthPositive(t1, 1).Should().Be(1);
        }

        [TestMethod]
        public void Test3()
        {
            var t1 = new int[] { 2, 3, 4, 7, 11 };
            Solution.FindKthPositive(t1, 5).Should().Be(9);
        }

        [TestMethod]
        public void Test4()
        {
            var t1 = new int[] { };
            Solution.FindKthPositive(t1, 1).Should().Be(1);
        }
    }
}

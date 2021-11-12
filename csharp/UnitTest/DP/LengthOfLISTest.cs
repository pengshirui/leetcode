namespace UnitTest.DP
{
    using FluentAssertions;
    using LeetCode.DP.LengthOfLIS;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LengthOfLISTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.LengthOfLIS(1, 3, 6, 7, 9, 4, 10, 5, 6).Should().Be(6);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.LengthOfLIS(10, 9, 2, 5, 3, 7, 101, 18).Should().Be(4);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.LengthOfLIS(4, 10, 4, 3, 8, 9).Should().Be(3);
        }
    }
}

namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.MinDifference;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MinDifferenceTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.MinDifference(5, 3, 2, 4).Should().Be(0);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.MinDifference(1, 3).Should().Be(0);
        }
    }
}

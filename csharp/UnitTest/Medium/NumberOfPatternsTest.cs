namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.NumberOfPatterns;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NumberOfPatternsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.NumberOfPatterns(1, 1).Should().Be(9);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.NumberOfPatterns(1, 2).Should().Be(65);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.NumberOfPatterns(1, 3).Should().Be(385);
        }

        [TestMethod]
        public void Test4()
        {
            Solution.NumberOfPatterns(1, 4).Should().Be(2009);
        }
    }
}

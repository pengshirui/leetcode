namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy.CountBinarySubstrings;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CountBinarySubstringsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.CountBinarySubstrings("00110011").Should().Be(6);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.CountBinarySubstrings("10101").Should().Be(4);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.CountBinarySubstrings("00110").Should().Be(3);
        }
    }
}

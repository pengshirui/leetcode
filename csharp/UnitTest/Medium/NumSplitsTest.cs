namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.NumSplits;
    using Microsoft.VisualStudio.TestTools.UnitTesting;


    [TestClass]
    public class NumSplitsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.NumSplits("aacaba").Should().Be(2);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.NumSplits("abcd").Should().Be(1);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.NumSplits("aaaaa").Should().Be(4);
        }
    }
}


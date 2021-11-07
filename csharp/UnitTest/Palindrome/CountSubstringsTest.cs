namespace UnitTest.Palindrome
{
    using FluentAssertions;
    using LeetCode.Palindrome.CountSubstrings;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CountSubstringsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.CountSubstrings("aaa").Should().Be(6);
        }


        [TestMethod]
        public void Test2()
        {
            Solution.CountSubstrings("aba").Should().Be(4);
        }

        [TestMethod]
        public void Test3()
        {
            Solution.CountSubstrings("aaaaa").Should().Be(15);
        }
    }
}

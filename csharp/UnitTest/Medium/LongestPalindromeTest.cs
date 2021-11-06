namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.LongestPalindrome;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LongestPalindromeTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.LongestPalindrome("babad").Should().Be("bab");
        }

        [TestMethod]
        public void Test2()
        {
            Solution.LongestPalindrome("cbbd").Should().Be("bb");
        }

        [TestMethod]
        public void Test3()
        {
            Solution.LongestPalindrome("a").Should().Be("a");
        }

        [TestMethod]
        public void Test4()
        {
            Solution.LongestPalindrome("ccc").Should().Be("ccc");
        }

        [TestMethod]
        public void Test5()
        {
            Solution.LongestPalindrome("bananas").Should().Be("anana");
        }
    }
}

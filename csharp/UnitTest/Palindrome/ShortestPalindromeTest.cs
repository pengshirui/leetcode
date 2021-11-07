namespace UnitTest.Palindrome
{
    using FluentAssertions;
    using LeetCode.Palindrome.ShortestPalindrome;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ShortestPalindromeTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.ShortestPalindrome("babad").Should().Be("dababad");
        }
    }
}

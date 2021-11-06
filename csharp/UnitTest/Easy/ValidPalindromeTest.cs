namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ValidPalindromeTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var str1 = "amanaplanacanalpanama";
            var str2 = "abc";
            var str3 = "aba";
            var str4 = "abca";
            var str5 = "tcaac";
            var str6 = "aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga";

            Solution.ValidPalindrome(str1).Should().BeTrue();
            Solution.ValidPalindrome(str2).Should().BeFalse();
            Solution.ValidPalindrome(str3).Should().BeTrue();
            Solution.ValidPalindrome(str4).Should().BeTrue();
            Solution.ValidPalindrome(str5).Should().BeTrue();
            Solution.ValidPalindrome(str6).Should().BeTrue();

        }
    }
}

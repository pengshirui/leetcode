namespace UnitTest.Easy
{
    using FluentAssertions;
    using LeetCode.Easy.IsPalindrome;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IsPalindromeTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var str = "A man, a plan, a canal: Panama";

            Solution.IsPalindrome(str).Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            var str = "race a car";

            Solution.IsPalindrome(str).Should().BeFalse();
        }

        [TestMethod]
        public void Test3()
        {
            var str = "                  ";

            Solution.IsPalindrome(str).Should().BeTrue();
        }

        [TestMethod]
        public void Test4()
        {
            var str = "aabbaa";

            Solution.IsPalindrome(str).Should().BeTrue();
        }

        [TestMethod]
        public void Test5()
        {
            Solution.IsPalindrome(1).Should().BeTrue();
        }

        [TestMethod]
        public void Test6()
        {
            Solution.IsPalindrome(-1).Should().BeFalse();
        }

        [TestMethod]
        public void Test7()
        {
            Solution.IsPalindrome(131).Should().BeTrue();
        }
    }
}

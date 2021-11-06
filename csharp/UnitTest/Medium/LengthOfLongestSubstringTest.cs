namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LengthOfLongestSubstringTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s1 = "abcabcbb";
            var s2 = "bbbbb";
            var s3 = "pwwkew";
            var s4 = "";
            var s5 = "a";
            var s6 = "                    ";
            _solution.LengthOfLongestSubstring(s1).Should().Be(3);
            _solution.LengthOfLongestSubstring(s2).Should().Be(1);
            _solution.LengthOfLongestSubstring(s3).Should().Be(3);
            _solution.LengthOfLongestSubstring(s4).Should().Be(0);
            _solution.LengthOfLongestSubstring(s5).Should().Be(1);
            _solution.LengthOfLongestSubstring(s6).Should().Be(1);

        }
    }
}

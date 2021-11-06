namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LengthOfLongestSubstringTwoDistinctTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s1 = "eceba";
            _solution.LengthOfLongestSubstringTwoDistinct(s1).Should().Be(3);
        }

        [TestMethod]
        public void Test2()
        {
            var s2 = "ccaabbb";
            _solution.LengthOfLongestSubstringTwoDistinct(s2).Should().Be(5);
        }
    }
}

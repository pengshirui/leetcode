namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LengthOfLongestSubstringKDistinctTest
    {
        readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s1 = "abcabcbb";
            _solution.LengthOfLongestSubstringKDistinct(s1, 1).Should().Be(2);
        }

        [TestMethod]
        public void Test2()
        {
            var s2 = "bbbbb";
            _solution.LengthOfLongestSubstringKDistinct(s2, 1).Should().Be(5);
        }

        [TestMethod]
        public void Test3()
        {
            var s3 = "eceba";
            _solution.LengthOfLongestSubstringKDistinct(s3, 2).Should().Be(3);
        }

        [TestMethod]
        public void Test4()
        {
            var s4 = "aa";
            _solution.LengthOfLongestSubstringKDistinct(s4, 1).Should().Be(2);
        }

        [TestMethod]
        public void Test5()
        {
            var s5 = "a";
            _solution.LengthOfLongestSubstringKDistinct(s5, 2).Should().Be(1);
        }
    }
}

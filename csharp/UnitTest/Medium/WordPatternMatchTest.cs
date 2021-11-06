namespace UnitTest.Medium
{
    using System.Collections.Generic;
    using FluentAssertions;
    using LeetCode.Medium.WordPatternMatch;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WordPatternMatchTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var pattern = "abab";
            var s = "redblueredblue";

            Solution.WordPatternMatch(pattern, s).Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            var pattern = "d";
            var s = "e";

            Solution.WordPatternMatch(pattern, s).Should().BeTrue();
        }

        [TestMethod]
        public void Test3()
        {
            var pattern = "ab";
            var s = "aa";

            Solution.WordPatternMatch(pattern, s).Should().BeFalse();
        }
    }
}

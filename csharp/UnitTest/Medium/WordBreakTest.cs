namespace UnitTest.Medium
{
    using System.Collections.Generic;
    using FluentAssertions;
    using LeetCode.Medium.WordBreak;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WordBreakTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s = "leetcode";
            var l = new List<string> { "leet", "code" };

            Solution.WordBreak(s, l).Should().BeTrue();
        }

        [TestMethod]
        public void Test2()
        {
            var s = "leetcode";
            var l = new List<string> { "lee", "tc", "ode" };

            Solution.WordBreak(s, l).Should().BeTrue();
        }


        [TestMethod]
        public void Test3()
        {
            var s = "leetcode";
            var l = new List<string> { "lee", "tc", "" };

            Solution.WordBreak(s, l).Should().BeFalse();
        }
    }
}

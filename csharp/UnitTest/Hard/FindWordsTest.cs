namespace UnitTest.Hard
{
    using System.Collections.Generic;
    using FluentAssertions;
    using LeetCode.Hard.FindWords;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindWordsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var board = new char[][]
            {
                new char[] { 'o', 'a', 'a', 'n' },
                new char[] { 'e', 't', 'a', 'e' },
                new char[] { 'i', 'h', 'k', 'r' },
                new char[] { 'i', 'f', 'l', 'v' },
            };
            var words = new string[] { "oath", "pea", "eat", "rain" };
            Solution.FindWords(board, words).Should().Contain(new List<string> { "eat", "oath" });
        }

        [TestMethod]
        public void Test2()
        {
            var board = new char[][]
            {
                new char[] { 'o', 'a', 'a', 'n' },
                new char[] { 'e', 't', 'a', 'e' },
                new char[] { 'i', 'h', 'k', 'r' },
                new char[] { 'i', 'f', 'l', 'v' },
            };
            var words = new string[] { "oath", "pea", "eat", "rain", "oathi", "oathk", "oathf", "oate", "oathii", "oathfi", "oathfii" };
            Solution.FindWords(board, words).Should().Contain(new List<string> { "oath", "oathk", "oathf", "oathfi", "oathfii", "oathi", "oathii", "oate", "eat" });
        }
    }
}

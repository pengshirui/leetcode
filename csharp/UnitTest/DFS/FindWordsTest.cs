namespace UnitTest.DFS
{
    using System.Collections.Generic;
    using FluentAssertions;
    using LeetCode.DFS.FindWords;
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
            Solution.FindWords(board, words).Should().Equal("oath", "eat");
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

        [TestMethod]
        public void Test3()
        {
            var board = new char[][]
            {
                new char[] { 'a', 'a' },
            };
            var words = new string[] { "aaa" };
            Solution.FindWords(board, words).Should().BeEmpty();
        }
    }
}

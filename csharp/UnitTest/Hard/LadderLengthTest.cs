namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LadderLengthTest
    {
        readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var beginWord = "hit";
            var endWord = "cog";
            var wordList = new string[] { "hot", "dot", "dog", "lot", "log", "cog" };
            Solution.LadderLength(beginWord, endWord, wordList).Should().Be(5);
        }

        [TestMethod]
        public void Test2()
        {
            var beginWord = "hit";
            var endWord = "hot";
            var wordList = new string[] { "hot", "dot", "dog", "lot", "log", "cog" };
            Solution.LadderLength(beginWord, endWord, wordList).Should().Be(2);
        }
    }
}

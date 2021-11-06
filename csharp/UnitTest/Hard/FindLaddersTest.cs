namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.FindLadders;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindLaddersTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var beginWord = "hit";
            var endWord = "cog";
            var wordList = new string[] { "hot", "dot", "dog", "lot", "log", "cog" };
            var r = Solution.FindLadders(beginWord, endWord, wordList);
            r[0].Should().Equal("hit", "hot", "dot", "dog", "cog");
            r[1].Should().Equal("hit", "hot", "lot", "log", "cog");
        }
    }
}

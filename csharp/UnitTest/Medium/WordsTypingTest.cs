namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.WordsTyping;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WordsTypingTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var sentence = new string[] { "hello", "world" };
            var rows = 2;
            var cols = 8;

            Solution.WordsTyping(sentence, rows, cols).Should().Be(1);
        }
    }
}

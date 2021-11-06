namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ExpressiveWordsTest
    {
        private readonly Solution _solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s = "heeellooo";
            var words = new string[] { "hello", "hi", "helo" };
            _solution.ExpressiveWords(s, words).Should().Be(1);
        }
    }
}

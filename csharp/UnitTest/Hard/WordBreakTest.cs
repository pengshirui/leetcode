namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.WordBreak;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WordBreakTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s = "catsanddog";
            var d = new string[] { "cat", "cats", "and", "sand", "dog" };
            var r = Solution.WordBreak(s, d);
            r[0].Should().Be("cat sand dog");
            r[1].Should().Be("cats and dog");
        }
    }
}

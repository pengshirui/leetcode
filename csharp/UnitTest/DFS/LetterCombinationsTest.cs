namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.DFS.LetterCombinations;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LetterCombinationsTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s = "23";
            Solution.LetterCombinations(s).Should().Equal("ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf");
        }

        [TestMethod]
        public void Test2()
        {
            var s = "";
            Solution.LetterCombinations(s).Should().HaveCount(0);
        }

        [TestMethod]
        public void Test3()
        {
            var s = "2";
            Solution.LetterCombinations(s).Should().Equal("a", "b", "c");
        }
    }
}

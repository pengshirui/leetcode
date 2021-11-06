namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.NumMatchingSubseq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NumMatchingSubseqTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s = "abcde";
            var words = new string[] { "a", "bb", "acd", "ace" };

            Solution.NumMatchingSubseq(s, words).Should().Be(3);
        }
        [TestMethod]
        public void Test2()
        {
            var s = "dsahjpjauf";
            var words = new string[] { "ahjpjau", "ja", "ahbwzgqnuk", "tnmlanowax" };

            Solution.NumMatchingSubseq(s, words).Should().Be(2);
        }
    }
}

namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard.MinWindowSubsequence;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MinWindowSubsequenceTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s1 = "abcdebdde";
            var s2 = "bde";
            Solution.MinWindowSubsequence(s1, s2).Should().Be("bcde");
        }
    }
}

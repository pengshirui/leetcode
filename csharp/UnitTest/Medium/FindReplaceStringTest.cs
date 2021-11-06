namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindReplaceStringTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s = "abcd";
            var indices = new int[] { 0, 2 };
            var sources = new string[] { "a", "cd" };
            var targets = new string[] { "eee", "ffff" };
            Solution.FindReplaceString(s, indices, sources, targets).Should().Be("eeebffff");
        }

        [TestMethod]
        public void Test2()
        {
            var s = "abcdabc";
            var indices = new int[] { 0, 2 };
            var sources = new string[] { "ab", "ec" };
            var targets = new string[] { "eee", "ffff" };
            Solution.FindReplaceString(s, indices, sources, targets).Should().Be("eeecdabc");
        }

        [TestMethod]
        public void Test3()
        {
            var s = "vmokgggqzp";
            var indices = new int[] { 3, 5, 1 };
            var sources = new string[] { "kg", "ggq", "mo" };
            var targets = new string[] { "s", "so", "bfr" };
            Solution.FindReplaceString(s, indices, sources, targets).Should().Be("vbfrssozp");
        }
    }
}

namespace UnitTest.Hard
{
    using FluentAssertions;
    using LeetCode.Hard;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MinWindowTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            var s = "ADOBECODEBANC";
            var t = "ABC";
            Solution.MinWindow(s, t).Should().Be("BANC");
        }

        [TestMethod]
        public void Test2()
        {
            var s = "a";
            var t = "a";
            Solution.MinWindow(s, t).Should().Be("a");
        }
        [TestMethod]
        public void Test3()
        {
            var s = "a";
            var t = "aa";
            Solution.MinWindow(s, t).Should().Be("");
        }

        [TestMethod]
        public void Test4()
        {
            var s = "bbaa";
            var t = "aba";
            Solution.MinWindow(s, t).Should().Be("baa");
        }

        [TestMethod]
        public void Test5()
        {
            var s = "a";
            var t = "b";
            Solution.MinWindow(s, t).Should().Be("");
        }

        [TestMethod]
        public void Test6()
        {
            var s = "ab";
            var t = "A";
            Solution.MinWindow(s, t).Should().Be("");
        }
    }
}

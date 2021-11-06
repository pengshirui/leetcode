namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.SimplifyPath;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SimplifyPathTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.SimplifyPath("/home/").Should().Be("/home");
        }

        [TestMethod]
        public void Test2()
        {
            Solution.SimplifyPath("/../").Should().Be("/");
        }

        [TestMethod]
        public void Test3()
        {
            Solution.SimplifyPath("/home/foo").Should().Be("/home/foo");
        }
    }
}

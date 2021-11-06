namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium.LongestStrChain;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LongestStrChainTest
    {
        private readonly Solution Solution = new Solution();

        [TestMethod]
        public void Test1()
        {
            Solution.LongestStrChain("a", "b", "ba", "bca", "bda", "bdca").Should().Be(4);
        }

        [TestMethod]
        public void Test2()
        {
            Solution.LongestStrChain("xbc", "pcxbcf", "xb", "cxbc", "pcxbc").Should().Be(5);
        }
    }
}
